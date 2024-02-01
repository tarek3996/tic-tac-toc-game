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
    public partial class Registration : Form
    {

        public Registration()
        {
            InitializeComponent();
            x_player1.Checked = true;
            o_player2.Checked = true;
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Registration_panal.Controls.Add(childForm);
            Registration_panal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player1_name.Text != "" && player2_name.Text != "")
            { openChildFormInPanel(new Form1vs1(this)); }

        }

        private void choose()
        {
            if (x_player1.Checked == true) { o_player2.Checked = true; }
            else if (o_player1.Checked == true) { x_player2.Checked = true; }
        }


        private void x_player_Click(object sender, EventArgs e)
        {
            choose();
        }

        public string get_name1()
        {
            return player1_name.Text;
        }

        public string get_name2()
        {
            return player2_name.Text;
        }

        public bool get_pattern()
        {
            return x_player1.Checked;
        }
    }
}
