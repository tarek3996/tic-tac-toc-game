namespace tic_tac_toc_game
{
    partial class Form1vs1
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
            c3 = new Button();
            c2 = new Button();
            c1 = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            a3 = new Button();
            a2 = new Button();
            a1 = new Button();
            reset_btn = new Button();
            o_playerName = new Label();
            player2_lbl = new Label();
            player1_lbl = new Label();
            x_playerName = new Label();
            groupBox_x = new GroupBox();
            groupBox1 = new GroupBox();
            save_btn = new Button();
            groupBox_x.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // c3
            // 
            c3.Anchor = AnchorStyles.Bottom;
            c3.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c3.Location = new Point(392, 363);
            c3.Name = "c3";
            c3.Size = new Size(75, 75);
            c3.TabIndex = 26;
            c3.UseVisualStyleBackColor = true;
            c3.Click += playerClick;
            // 
            // c2
            // 
            c2.Anchor = AnchorStyles.Bottom;
            c2.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c2.Location = new Point(234, 363);
            c2.Name = "c2";
            c2.Size = new Size(75, 75);
            c2.TabIndex = 25;
            c2.UseVisualStyleBackColor = true;
            c2.Click += playerClick;
            // 
            // c1
            // 
            c1.Anchor = AnchorStyles.Bottom;
            c1.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c1.Location = new Point(68, 363);
            c1.Name = "c1";
            c1.Size = new Size(75, 75);
            c1.TabIndex = 24;
            c1.UseVisualStyleBackColor = true;
            c1.Click += playerClick;
            // 
            // b3
            // 
            b3.Anchor = AnchorStyles.Bottom;
            b3.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b3.Location = new Point(392, 236);
            b3.Name = "b3";
            b3.Size = new Size(75, 75);
            b3.TabIndex = 23;
            b3.UseVisualStyleBackColor = true;
            b3.Click += playerClick;
            // 
            // b2
            // 
            b2.Anchor = AnchorStyles.Bottom;
            b2.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b2.Location = new Point(234, 236);
            b2.Name = "b2";
            b2.Size = new Size(75, 75);
            b2.TabIndex = 22;
            b2.UseVisualStyleBackColor = true;
            b2.Click += playerClick;
            // 
            // b1
            // 
            b1.Anchor = AnchorStyles.Bottom;
            b1.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b1.Location = new Point(68, 236);
            b1.Name = "b1";
            b1.Size = new Size(75, 75);
            b1.TabIndex = 21;
            b1.UseVisualStyleBackColor = true;
            b1.Click += playerClick;
            // 
            // a3
            // 
            a3.Anchor = AnchorStyles.Bottom;
            a3.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a3.Location = new Point(392, 116);
            a3.Name = "a3";
            a3.Size = new Size(75, 75);
            a3.TabIndex = 20;
            a3.UseVisualStyleBackColor = true;
            a3.Click += playerClick;
            // 
            // a2
            // 
            a2.Anchor = AnchorStyles.Bottom;
            a2.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a2.Location = new Point(234, 116);
            a2.Name = "a2";
            a2.Size = new Size(75, 75);
            a2.TabIndex = 19;
            a2.UseVisualStyleBackColor = true;
            a2.Click += playerClick;
            // 
            // a1
            // 
            a1.Anchor = AnchorStyles.Bottom;
            a1.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a1.Location = new Point(68, 116);
            a1.Name = "a1";
            a1.Size = new Size(75, 75);
            a1.TabIndex = 18;
            a1.UseVisualStyleBackColor = true;
            a1.Click += playerClick;
            // 
            // reset_btn
            // 
            reset_btn.Anchor = AnchorStyles.Top;
            reset_btn.BackColor = Color.Orange;
            reset_btn.Font = new Font("Snap ITC", 14.25F);
            reset_btn.ForeColor = SystemColors.ActiveCaptionText;
            reset_btn.Location = new Point(221, 12);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(99, 38);
            reset_btn.TabIndex = 29;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += restartGame;
            // 
            // o_playerName
            // 
            o_playerName.Anchor = AnchorStyles.Top;
            o_playerName.AutoSize = true;
            o_playerName.Font = new Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            o_playerName.ForeColor = Color.Black;
            o_playerName.Location = new Point(56, 18);
            o_playerName.Name = "o_playerName";
            o_playerName.Size = new Size(95, 31);
            o_playerName.TabIndex = 31;
            o_playerName.Text = "player 2";
            // 
            // player2_lbl
            // 
            player2_lbl.Anchor = AnchorStyles.Top;
            player2_lbl.AutoSize = true;
            player2_lbl.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            player2_lbl.ForeColor = Color.Black;
            player2_lbl.Location = new Point(86, 53);
            player2_lbl.Name = "player2_lbl";
            player2_lbl.Size = new Size(26, 24);
            player2_lbl.TabIndex = 33;
            player2_lbl.Text = "0 ";
            // 
            // player1_lbl
            // 
            player1_lbl.Anchor = AnchorStyles.Top;
            player1_lbl.AutoSize = true;
            player1_lbl.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            player1_lbl.ForeColor = Color.Black;
            player1_lbl.Location = new Point(85, 53);
            player1_lbl.Name = "player1_lbl";
            player1_lbl.Size = new Size(21, 24);
            player1_lbl.TabIndex = 32;
            player1_lbl.Text = "0";
            // 
            // x_playerName
            // 
            x_playerName.Anchor = AnchorStyles.Top;
            x_playerName.AutoSize = true;
            x_playerName.Font = new Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            x_playerName.ForeColor = Color.Black;
            x_playerName.Location = new Point(56, 18);
            x_playerName.Name = "x_playerName";
            x_playerName.Size = new Size(88, 31);
            x_playerName.TabIndex = 30;
            x_playerName.Text = "player 1";
            // 
            // groupBox_x
            // 
            groupBox_x.Controls.Add(x_playerName);
            groupBox_x.Controls.Add(player1_lbl);
            groupBox_x.Font = new Font("Ravie", 15.75F, FontStyle.Italic);
            groupBox_x.ForeColor = Color.DarkGreen;
            groupBox_x.Location = new Point(12, 12);
            groupBox_x.Name = "groupBox_x";
            groupBox_x.Size = new Size(200, 80);
            groupBox_x.TabIndex = 36;
            groupBox_x.TabStop = false;
            groupBox_x.Text = "x";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(o_playerName);
            groupBox1.Controls.Add(player2_lbl);
            groupBox1.Font = new Font("Ravie", 15.75F, FontStyle.Italic);
            groupBox1.ForeColor = Color.Tomato;
            groupBox1.Location = new Point(326, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 80);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "o";
            // 
            // save_btn
            // 
            save_btn.Anchor = AnchorStyles.Top;
            save_btn.BackColor = Color.LightGreen;
            save_btn.Font = new Font("Snap ITC", 14.25F);
            save_btn.ForeColor = SystemColors.ActiveCaptionText;
            save_btn.Location = new Point(221, 65);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(99, 38);
            save_btn.TabIndex = 38;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // Form1vs1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(533, 461);
            Controls.Add(save_btn);
            Controls.Add(groupBox1);
            Controls.Add(groupBox_x);
            Controls.Add(reset_btn);
            Controls.Add(c3);
            Controls.Add(c2);
            Controls.Add(c1);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(a3);
            Controls.Add(a2);
            Controls.Add(a1);
            Name = "Form1vs1";
            Text = "_1vs1";
            groupBox_x.ResumeLayout(false);
            groupBox_x.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button c3;
        private Button c2;
        private Button c1;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button a3;
        private Button a2;
        private Button a1;
        private Button reset_btn;
        private Label o_playerName;
        private Label player2_lbl;
        private Label x;
        private Label player1_lbl;
        private Label x_playerName;
        private GroupBox groupBox_x;
        private GroupBox groupBox1;
        private Button save_btn;
    }
}