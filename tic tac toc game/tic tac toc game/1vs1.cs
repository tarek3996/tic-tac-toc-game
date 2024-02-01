using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toc_game
{
    public partial class Form1vs1 : Form
    {
        public enum player { x, o }
        player currentPlayer;
        int player1Wins = 0;
        int player2Wins = 0;
        List<Button> buttons;
        private bool isPlayer1Turn = true;
        Registration registration1;
        string name1;
        string name2;
        bool checkX;
        public Form1vs1(Registration registration)
        {

            InitializeComponent();
            restartGame();
            registration1 = registration;
            name1 = registration.get_name1();
            name2 = registration.get_name2();
            checkX = registration.get_pattern();
            if (checkX == true) { x_playerName.Text = name1; o_playerName.Text = name2; }
            else { o_playerName.Text = name1; x_playerName.Text = name2; }

        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button.Text == "")
            {
                if (isPlayer1Turn)
                {
                    currentPlayer = player.x;
                    button.Text = currentPlayer.ToString();
                    button.Enabled = false;
                    button.BackColor = Color.Cyan;
                }
                else
                {
                    currentPlayer = player.o;
                    button.Text = currentPlayer.ToString();
                    button.Enabled = false;
                    button.BackColor = Color.DarkSalmon;
                }

                buttons.Remove(button);
                cheackGame();
                isPlayer1Turn = !isPlayer1Turn;
            }
        }

        private void restartGame(object sender, EventArgs e)
        {
            restartGame();
        }

        private void cheackGame()
        {
            if (a1.Text == "x" && a2.Text == "x" && a3.Text == "x"
                || b1.Text == "x" && b2.Text == "x" && b3.Text == "x"
                || c1.Text == "x" && c2.Text == "x" && c3.Text == "x"
                || a1.Text == "x" && b1.Text == "x" && c1.Text == "x"
                || a2.Text == "x" && b2.Text == "x" && c2.Text == "x"
                || a3.Text == "x" && b3.Text == "x" && c3.Text == "x"
                || a1.Text == "x" && b2.Text == "x" && c3.Text == "x"
                || a3.Text == "x" && b2.Text == "x" && c1.Text == "x")
            {
                MessageBox.Show(x_playerName.Text + " Wins");
                player1Wins++;
                player1_lbl.Text = "" + player1Wins;
                restartGame();
            }
            else if (a1.Text == "o" && a2.Text == "o" && a3.Text == "o"
                || b1.Text == "o" && b2.Text == "o" && b3.Text == "o"
                || c1.Text == "o" && c2.Text == "o" && c3.Text == "o"
                || a1.Text == "o" && b1.Text == "o" && c1.Text == "o"
                || a2.Text == "o" && b2.Text == "o" && c2.Text == "o"
                || a3.Text == "o" && b3.Text == "o" && c3.Text == "o"
                || a1.Text == "o" && b2.Text == "o" && c3.Text == "o"
                || a3.Text == "o" && b2.Text == "o" && c1.Text == "o")
            {
                MessageBox.Show(o_playerName.Text + " Wins");
                player2Wins++;
                player2_lbl.Text = "" + player2Wins;
                restartGame();
            }
        }

        private void restartGame()
        {
            buttons = new List<Button> { a1, a2, a3, b1, b2, b3, c1, c2, c3 };
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "";
                x.BackColor = DefaultBackColor;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            db_context.ExecuteNonQuery($"insert into [dbo].[tic tac toe score table] values ('{x_playerName.Text}',{player1Wins},'{o_playerName.Text}',{player2Wins})", "Server=.;Database=tic tac toe;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
