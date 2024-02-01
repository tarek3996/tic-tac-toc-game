namespace tic_tac_toc_game
{
    partial class single_player
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
            components = new System.ComponentModel.Container();
            c3 = new Button();
            c2 = new Button();
            c1 = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            a3 = new Button();
            a2 = new Button();
            a1 = new Button();
            player_lbl = new Label();
            com_lbl = new Label();
            reset_btn = new Button();
            AI_timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            o = new Label();
            x = new Label();
            SuspendLayout();
            // 
            // c3
            // 
            c3.Anchor = AnchorStyles.Bottom;
            c3.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c3.Location = new Point(391, 363);
            c3.Name = "c3";
            c3.Size = new Size(75, 75);
            c3.TabIndex = 17;
            c3.TextAlign = ContentAlignment.TopCenter;
            c3.UseVisualStyleBackColor = true;
            c3.Click += playerClick;
            // 
            // c2
            // 
            c2.Anchor = AnchorStyles.Bottom;
            c2.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c2.Location = new Point(233, 363);
            c2.Name = "c2";
            c2.Size = new Size(75, 75);
            c2.TabIndex = 16;
            c2.TextAlign = ContentAlignment.TopCenter;
            c2.UseVisualStyleBackColor = true;
            c2.Click += playerClick;
            // 
            // c1
            // 
            c1.Anchor = AnchorStyles.Bottom;
            c1.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c1.Location = new Point(67, 363);
            c1.Name = "c1";
            c1.Size = new Size(75, 75);
            c1.TabIndex = 15;
            c1.TextAlign = ContentAlignment.TopCenter;
            c1.UseVisualStyleBackColor = true;
            c1.Click += playerClick;
            // 
            // b3
            // 
            b3.Anchor = AnchorStyles.Bottom;
            b3.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b3.Location = new Point(391, 236);
            b3.Name = "b3";
            b3.Size = new Size(75, 75);
            b3.TabIndex = 14;
            b3.TextAlign = ContentAlignment.TopCenter;
            b3.UseVisualStyleBackColor = true;
            b3.Click += playerClick;
            // 
            // b2
            // 
            b2.Anchor = AnchorStyles.Bottom;
            b2.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b2.Location = new Point(233, 236);
            b2.Name = "b2";
            b2.Size = new Size(75, 75);
            b2.TabIndex = 13;
            b2.TextAlign = ContentAlignment.TopCenter;
            b2.UseVisualStyleBackColor = true;
            b2.Click += playerClick;
            // 
            // b1
            // 
            b1.Anchor = AnchorStyles.Bottom;
            b1.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b1.Location = new Point(67, 236);
            b1.Name = "b1";
            b1.Size = new Size(75, 75);
            b1.TabIndex = 12;
            b1.TextAlign = ContentAlignment.TopCenter;
            b1.UseVisualStyleBackColor = true;
            b1.Click += playerClick;
            // 
            // a3
            // 
            a3.Anchor = AnchorStyles.Bottom;
            a3.BackColor = Color.Turquoise;
            a3.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a3.Location = new Point(391, 116);
            a3.Name = "a3";
            a3.Size = new Size(75, 75);
            a3.TabIndex = 11;
            a3.TextAlign = ContentAlignment.TopCenter;
            a3.UseVisualStyleBackColor = false;
            a3.Click += playerClick;
            // 
            // a2
            // 
            a2.Anchor = AnchorStyles.Bottom;
            a2.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a2.Location = new Point(233, 116);
            a2.Name = "a2";
            a2.Size = new Size(75, 75);
            a2.TabIndex = 10;
            a2.TextAlign = ContentAlignment.TopCenter;
            a2.UseVisualStyleBackColor = true;
            a2.Click += playerClick;
            // 
            // a1
            // 
            a1.Anchor = AnchorStyles.Bottom;
            a1.Font = new Font("Microsoft Sans Serif", 39F, FontStyle.Regular, GraphicsUnit.Point, 0);
            a1.Location = new Point(67, 116);
            a1.Name = "a1";
            a1.Size = new Size(75, 75);
            a1.TabIndex = 9;
            a1.TextAlign = ContentAlignment.TopCenter;
            a1.UseVisualStyleBackColor = true;
            a1.Click += playerClick;
            // 
            // player_lbl
            // 
            player_lbl.Anchor = AnchorStyles.Top;
            player_lbl.AutoSize = true;
            player_lbl.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            player_lbl.ForeColor = Color.Black;
            player_lbl.Location = new Point(122, 38);
            player_lbl.Name = "player_lbl";
            player_lbl.Size = new Size(21, 24);
            player_lbl.TabIndex = 18;
            player_lbl.Text = "0";
            // 
            // com_lbl
            // 
            com_lbl.Anchor = AnchorStyles.Top;
            com_lbl.AutoSize = true;
            com_lbl.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            com_lbl.ForeColor = Color.Black;
            com_lbl.Location = new Point(483, 37);
            com_lbl.Name = "com_lbl";
            com_lbl.Size = new Size(26, 24);
            com_lbl.TabIndex = 19;
            com_lbl.Text = "0 ";
            // 
            // reset_btn
            // 
            reset_btn.Anchor = AnchorStyles.Top;
            reset_btn.BackColor = Color.Orange;
            reset_btn.Font = new Font("Snap ITC", 14.25F);
            reset_btn.ForeColor = SystemColors.ActiveCaptionText;
            reset_btn.Location = new Point(220, 29);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(99, 38);
            reset_btn.TabIndex = 20;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += restartGame;
            // 
            // AI_timer
            // 
            AI_timer.Interval = 1000;
            AI_timer.Tick += AI_move;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(31, 36);
            label1.Name = "label1";
            label1.Size = new Size(93, 31);
            label1.TabIndex = 21;
            label1.Text = "player : ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(368, 36);
            label2.Name = "label2";
            label2.Size = new Size(119, 31);
            label2.TabIndex = 22;
            label2.Text = "computer : ";
            // 
            // o
            // 
            o.AutoSize = true;
            o.Font = new Font("Ravie", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            o.ForeColor = Color.Salmon;
            o.Location = new Point(411, 6);
            o.Name = "o";
            o.Size = new Size(28, 30);
            o.TabIndex = 37;
            o.Text = "o";
            // 
            // x
            // 
            x.AutoSize = true;
            x.Font = new Font("Ravie", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            x.ForeColor = Color.SeaGreen;
            x.Location = new Point(71, 6);
            x.Name = "x";
            x.Size = new Size(30, 30);
            x.TabIndex = 36;
            x.Text = "x";
            // 
            // single_player
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(533, 461);
            Controls.Add(o);
            Controls.Add(x);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reset_btn);
            Controls.Add(com_lbl);
            Controls.Add(player_lbl);
            Controls.Add(c3);
            Controls.Add(c2);
            Controls.Add(c1);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(a3);
            Controls.Add(a2);
            Controls.Add(a1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "single_player";
            Text = "single_player";
            ResumeLayout(false);
            PerformLayout();
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
        private Label player_lbl;
        private Label com_lbl;
        private Button reset_btn;
        private System.Windows.Forms.Timer AI_timer;
        private Label label1;
        private Label label2;
        private Label o;
        private Label x;
    }
}