namespace tic_tac_toc_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            optionPannelDessign();
        }
        private void optionPannelDessign()
        {
            option_panel.Visible = false;
        }

        private void hideOptionPannel()
        {
            if (option_panel.Visible == true) { option_panel.Visible = false; }
        }

        private void showOptionPannel(Panel OptionPannel)
        {
            if (option_panel.Visible == false)
            {
                hideOptionPannel();
                option_panel.Visible = true;

            }
            else { option_panel.Visible = false; }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            showOptionPannel(option_panel);
            play_btn.BackColor = Color.MediumTurquoise;
            table_btn.BackColor = Color.LightSeaGreen;
            about_btn.BackColor = Color.LightSeaGreen;

        }

        private void table_btn_Click(object sender, EventArgs e)
        {
            table_btn.BackColor = Color.MediumTurquoise;
            play_btn.BackColor = Color.LightSeaGreen;
            about_btn.BackColor = Color.LightSeaGreen;
            openChildFormInPanel(new score_table());
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            about_btn.BackColor = Color.MediumTurquoise;
            play_btn.BackColor = Color.LightSeaGreen;
            table_btn.BackColor = Color.LightSeaGreen;
            openChildFormInPanel(new about_form());
        }

        private void single_player_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new single_player());
            hideOptionPannel();
        }

        private void one_vs_one_btn_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Registration());
            hideOptionPannel();
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
            container_panal.Controls.Add(childForm);
            container_panal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

       
    }
}
