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
    public partial class single_player : Form
    {
        public enum player { x, o }
        player currentPlayer; 
        Random random = new Random();
        int playerWins = 0; 
        int computerWins = 0; 
        List<Button> buttons;
        private bool isPlayerTurn = true;

        public single_player()
        {
            InitializeComponent();
            restartGame();
        }

        private void playerClick(object sender, EventArgs e)
        {
            if (isPlayerTurn)
            {
                var button = (Button)sender;
                currentPlayer = player.x;
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.Cyan;
                buttons.Remove(button);
                cheackGame();
                isPlayerTurn = false;
                AI_timer.Start();
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
                AI_timer.Stop();
                MessageBox.Show("Player Wins"); 
                playerWins++; 
                player_lbl.Text = "" + playerWins; 
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
                AI_timer.Stop();
                MessageBox.Show("Computer Wins"); 
                computerWins++; 
                com_lbl.Text = "" + computerWins;
                restartGame();
            }




        }

        private void restartGame()
        {
            buttons = new List<Button> {a1,a2,a3,b1,b2,b3,c1,c2,c3};
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "";
                x.BackColor = DefaultBackColor;

            }
        }

        private void AI_move(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = player.o;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.DarkSalmon;
                buttons.RemoveAt(index);
                cheackGame();
                AI_timer.Stop();
                isPlayerTurn = true; 
            }
        }
    }
}
