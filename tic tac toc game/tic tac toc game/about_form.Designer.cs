namespace tic_tac_toc_game
{
    partial class about_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about_form));
            about_lbl = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // about_lbl
            // 
            about_lbl.Dock = DockStyle.Fill;
            about_lbl.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            about_lbl.Location = new Point(0, 0);
            about_lbl.Name = "about_lbl";
            about_lbl.Size = new Size(533, 461);
            about_lbl.TabIndex = 1;
            about_lbl.Text = resources.GetString("about_lbl.Text");
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(0, 431);
            label2.Name = "label2";
            label2.Size = new Size(533, 30);
            label2.TabIndex = 2;
            label2.Text = "Created By Tarek © 2024 - c#";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // about_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(533, 461);
            Controls.Add(label2);
            Controls.Add(about_lbl);
            Name = "about_form";
            Text = "about_form";
            ResumeLayout(false);
        }

        #endregion
        private Label about_lbl;
        private Label label2;
    }
}