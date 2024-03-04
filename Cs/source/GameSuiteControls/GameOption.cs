using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSuiteControls
{
    public partial class GameOption: UserControl
    {
        //Private variables to actually hold values
        private string game_name;
        private Int64 high_score;
        private TimeSpan time_played;
        //Public facing variables used for easy access/control
        public string GameName {
            get
            {
                return game_name;
            }
            set
            {
                game_name = value;
                this.GameLabel.Text = game_name;
            }
        }
        public Int64 HighScore
        {
            get
            {
                return high_score;
            }
            set
            {
                high_score = value;
                UpdateStats();
            }
        }
        public TimeSpan TimePlayed
        {
            get
            {
                return time_played;
            }
            set
            {
                time_played = value;
                UpdateStats();
            }
        }

        public GameOption()
        {
            InitializeComponent();
            GameName = String.Empty;
            HighScore = 0;
            TimePlayed = TimeSpan.Zero;
        }

        private void UpdateStats()
        {
            this.StatsLabel.Text = "Highscore: " + ScoreToString(high_score);
            this.StatsLabel.Text += "\nTime played: " + TimeToString(time_played);
        }

        private string ScoreToString(Int64 score)
        {
            string builder = String.Empty;

            if (high_score < 0)
                builder = "--";
            else
                builder = score.ToString();

            return builder;
        }

        private string TimeToString(TimeSpan time)
        {
            string builder = String.Empty;

            if (time.TotalHours > 1.0d)
            {
                //Case for multiple days of play time
                builder = time.TotalHours.ToString();
                builder += " hrs";
            }
            else if (time.TotalMinutes > 0d)
            {
                //Case for 0min < time <= 60min
                builder = time.TotalMinutes.ToString();
                builder += " mins";
            }
            else if (time.TotalMilliseconds < 0)
            {
                //Case for time < 0, indicating no play time has occurred
                builder = "--";
            }
            else
            {
                //In all other cases, return 0 minutes
                builder = "0 min";
            }

            return builder;
        }
    }
}
