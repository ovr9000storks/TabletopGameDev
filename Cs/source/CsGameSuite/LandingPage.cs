using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsGameSuite
{
    public partial class LandingPage : Form
    {
        //** COLORS **//
        readonly Color Green_Element = Color.FromArgb(69, 143, 75);         // #458F4B
        readonly Color LGreen_Element = Color.FromArgb(41, 217, 56);        // #29D938
        readonly Color Yellow_Element = Color.FromArgb(217, 167, 41);       // #D9A729
        readonly Color Magenta_Element = Color.FromArgb(217, 41, 103);      // #D92967
        readonly Color Blue_Element = Color.FromArgb(41, 89, 217);          // #2959D9
        readonly Color Brown_Element = Color.FromArgb(143, 82, 56);         // #8f5238
        readonly Color Red_UI = Color.FromArgb(176, 21, 55);                // #b01537
        readonly Color Green_UI = Color.FromArgb(28, 162, 38);              // #1ca226
        readonly Color Yellow_UI = Color.FromArgb(217, 184, 25);            // #d9b819
        readonly Color White_UI = Color.FromArgb(226, 226, 226);            // #e2e2e2
        readonly Color DarkGrey_UI = Color.FromArgb(38, 39, 42);            // #26272a
        readonly Color Black_UI = Color.FromArgb(12, 14, 19);               // #0c0e13

        public LandingPage()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            //Top nav menu

            //Singleplayer games

            SolitaireOption.GameName = "SOLITAIRE";
            SolitaireOption.HighScore = -1;
            SolitaireOption.TimePlayed = TimeSpan.FromSeconds(-1);

            BlackjackOption.GameName = "BLACKJACK";
            BlackjackOption.HighScore = -1;
            BlackjackOption.TimePlayed = TimeSpan.FromSeconds(-1);

            TetrisOption.GameName = "TETRIS";
            TetrisOption.HighScore = -1;
            TetrisOption.TimePlayed = TimeSpan.FromSeconds(-1);

            SodokuOption.GameName = "SODOKU";
            SodokuOption.HighScore = -1;
            SodokuOption.TimePlayed = TimeSpan.FromSeconds(-1);

            NonogramOption.GameName = "NONOGRAMS";
            NonogramOption.HighScore = -1;
            NonogramOption.TimePlayed = TimeSpan.FromSeconds(-1);

            BreakoutOption.GameName = "BREAKOUT";
            BreakoutOption.HighScore = -1;
            BreakoutOption.TimePlayed = TimeSpan.FromSeconds(-1);

            MineSweeperOption.GameName = "MINE SWEEPER";
            MineSweeperOption.HighScore = -1;
            MineSweeperOption.TimePlayed = TimeSpan.FromSeconds(-1);

            Game2048Option.GameName = "2048";
            Game2048Option.HighScore = -1;
            Game2048Option.TimePlayed = TimeSpan.FromSeconds(-1);

            SimonSaysOption.GameName = "SIMON SAYS";
            SimonSaysOption.HighScore = -1;
            SimonSaysOption.TimePlayed = TimeSpan.FromSeconds(-1);

            HanoiTowerOption.GameName = "TOWER OF HANOI";
            HanoiTowerOption.HighScore = -1;
            HanoiTowerOption.TimePlayed = TimeSpan.FromSeconds(-1);

            //Multiplayer games

            ChessOption.GameName = "CHESS";
            ChessOption.HighScore = -1;
            ChessOption.TimePlayed = TimeSpan.FromSeconds(-1);

            CheckersOption.GameName = "CHECKERS";
            CheckersOption.HighScore = -1;
            CheckersOption.TimePlayed = TimeSpan.FromSeconds(-1);

            BackgammonOption.GameName = "BACKGAMMON";
            BackgammonOption.HighScore = -1;
            BackgammonOption.TimePlayed = TimeSpan.FromSeconds(-1);

            PaiShoOption.GameName = "PAI SHO";
            PaiShoOption.HighScore = -1;
            PaiShoOption.TimePlayed = TimeSpan.FromSeconds(-1);
        }
    }
}
