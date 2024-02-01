namespace tic_tac_toc_game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            logo_panel = new Panel();
            logo = new PictureBox();
            play_btn = new Button();
            option_panel = new Panel();
            one_vs_one_btn = new Button();
            single_player_btn = new Button();
            slide_panel = new Panel();
            about_btn = new Button();
            table_btn = new Button();
            container_panal = new Panel();
            background_pic = new PictureBox();
            logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            option_panel.SuspendLayout();
            slide_panel.SuspendLayout();
            container_panal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)background_pic).BeginInit();
            SuspendLayout();
            // 
            // logo_panel
            // 
            logo_panel.Controls.Add(logo);
            logo_panel.Dock = DockStyle.Top;
            logo_panel.Location = new Point(0, 0);
            logo_panel.Name = "logo_panel";
            logo_panel.Size = new Size(201, 100);
            logo_panel.TabIndex = 0;
            // 
            // logo
            // 
            logo.Dock = DockStyle.Fill;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(201, 100);
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // play_btn
            // 
            play_btn.Dock = DockStyle.Top;
            play_btn.FlatAppearance.BorderSize = 0;
            play_btn.FlatStyle = FlatStyle.Flat;
            play_btn.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            play_btn.ForeColor = Color.Gainsboro;
            play_btn.Location = new Point(0, 100);
            play_btn.Name = "play_btn";
            play_btn.Size = new Size(201, 43);
            play_btn.TabIndex = 1;
            play_btn.Text = "Play";
            play_btn.TextAlign = ContentAlignment.MiddleLeft;
            play_btn.UseVisualStyleBackColor = true;
            play_btn.Click += play_btn_Click;
            // 
            // option_panel
            // 
            option_panel.Controls.Add(one_vs_one_btn);
            option_panel.Controls.Add(single_player_btn);
            option_panel.Dock = DockStyle.Top;
            option_panel.Location = new Point(0, 143);
            option_panel.Name = "option_panel";
            option_panel.Size = new Size(201, 100);
            option_panel.TabIndex = 1;
            // 
            // one_vs_one_btn
            // 
            one_vs_one_btn.Dock = DockStyle.Top;
            one_vs_one_btn.FlatAppearance.BorderSize = 0;
            one_vs_one_btn.FlatStyle = FlatStyle.Flat;
            one_vs_one_btn.Font = new Font("Snap ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            one_vs_one_btn.ForeColor = Color.Gainsboro;
            one_vs_one_btn.Location = new Point(0, 36);
            one_vs_one_btn.Name = "one_vs_one_btn";
            one_vs_one_btn.Size = new Size(201, 36);
            one_vs_one_btn.TabIndex = 2;
            one_vs_one_btn.Text = "1 vs 1";
            one_vs_one_btn.UseVisualStyleBackColor = true;
            one_vs_one_btn.Click += one_vs_one_btn_Click;
            // 
            // single_player_btn
            // 
            single_player_btn.Dock = DockStyle.Top;
            single_player_btn.FlatAppearance.BorderSize = 0;
            single_player_btn.FlatStyle = FlatStyle.Flat;
            single_player_btn.Font = new Font("Snap ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            single_player_btn.ForeColor = Color.Gainsboro;
            single_player_btn.Location = new Point(0, 0);
            single_player_btn.Name = "single_player_btn";
            single_player_btn.Size = new Size(201, 36);
            single_player_btn.TabIndex = 1;
            single_player_btn.Text = "single_player";
            single_player_btn.UseVisualStyleBackColor = true;
            single_player_btn.Click += single_player_btn_Click;
            // 
            // slide_panel
            // 
            slide_panel.AutoScroll = true;
            slide_panel.BackColor = Color.LightSeaGreen;
            slide_panel.Controls.Add(about_btn);
            slide_panel.Controls.Add(table_btn);
            slide_panel.Controls.Add(option_panel);
            slide_panel.Controls.Add(play_btn);
            slide_panel.Controls.Add(logo_panel);
            slide_panel.Dock = DockStyle.Left;
            slide_panel.Location = new Point(0, 0);
            slide_panel.Name = "slide_panel";
            slide_panel.Size = new Size(201, 461);
            slide_panel.TabIndex = 0;
            // 
            // about_btn
            // 
            about_btn.Dock = DockStyle.Top;
            about_btn.FlatAppearance.BorderSize = 0;
            about_btn.FlatStyle = FlatStyle.Flat;
            about_btn.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            about_btn.ForeColor = Color.Gainsboro;
            about_btn.Location = new Point(0, 286);
            about_btn.Name = "about_btn";
            about_btn.Size = new Size(201, 43);
            about_btn.TabIndex = 3;
            about_btn.Text = "About";
            about_btn.TextAlign = ContentAlignment.MiddleLeft;
            about_btn.UseVisualStyleBackColor = true;
            about_btn.Click += about_btn_Click;
            // 
            // table_btn
            // 
            table_btn.Dock = DockStyle.Top;
            table_btn.FlatAppearance.BorderSize = 0;
            table_btn.FlatStyle = FlatStyle.Flat;
            table_btn.Font = new Font("Viner Hand ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            table_btn.ForeColor = Color.Gainsboro;
            table_btn.Location = new Point(0, 243);
            table_btn.Name = "table_btn";
            table_btn.Size = new Size(201, 43);
            table_btn.TabIndex = 2;
            table_btn.Text = "Table";
            table_btn.TextAlign = ContentAlignment.MiddleLeft;
            table_btn.UseVisualStyleBackColor = true;
            table_btn.Click += table_btn_Click;
            // 
            // container_panal
            // 
            container_panal.BackColor = Color.Turquoise;
            container_panal.Controls.Add(background_pic);
            container_panal.Dock = DockStyle.Fill;
            container_panal.Location = new Point(201, 0);
            container_panal.Name = "container_panal";
            container_panal.Size = new Size(533, 461);
            container_panal.TabIndex = 1;
            // 
            // background_pic
            // 
            background_pic.Dock = DockStyle.Fill;
            background_pic.Image = (Image)resources.GetObject("background_pic.Image");
            background_pic.Location = new Point(0, 0);
            background_pic.Name = "background_pic";
            background_pic.Size = new Size(533, 461);
            background_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            background_pic.TabIndex = 0;
            background_pic.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(container_panal);
            Controls.Add(slide_panel);
            Font = new Font("Segoe UI", 10F);
            MaximizeBox = false;
            MinimumSize = new Size(750, 500);
            Name = "Form1";
            Text = "tic tac toc";
            logo_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            option_panel.ResumeLayout(false);
            slide_panel.ResumeLayout(false);
            container_panal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)background_pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel logo_panel;
        private Button play_btn;
        private Panel option_panel;
        private Button one_vs_one_btn;
        private Button single_player_btn;
        private Panel slide_panel;
        private Button about_btn;
        private Button table_btn;
        private PictureBox logo;
        private Panel container_panal;
        private PictureBox background_pic;
    }
}
