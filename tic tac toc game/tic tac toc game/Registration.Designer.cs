namespace tic_tac_toc_game
{
    partial class Registration
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
            Registration_panal = new Panel();
            button1 = new Button();
            groupBox2 = new GroupBox();
            o_player2 = new RadioButton();
            x_player2 = new RadioButton();
            player2_name = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            o_player1 = new RadioButton();
            x_player1 = new RadioButton();
            player1_name = new TextBox();
            label1 = new Label();
            Registration_panal.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Registration_panal
            // 
            Registration_panal.Controls.Add(button1);
            Registration_panal.Controls.Add(groupBox2);
            Registration_panal.Controls.Add(groupBox1);
            Registration_panal.Dock = DockStyle.Fill;
            Registration_panal.Location = new Point(0, 0);
            Registration_panal.Name = "Registration_panal";
            Registration_panal.Size = new Size(533, 461);
            Registration_panal.TabIndex = 39;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Viner Hand ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(192, 311);
            button1.Name = "button1";
            button1.Size = new Size(146, 44);
            button1.TabIndex = 41;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(o_player2);
            groupBox2.Controls.Add(x_player2);
            groupBox2.Controls.Add(player2_name);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(269, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(255, 120);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            groupBox2.Text = "player 2";
            // 
            // o_player2
            // 
            o_player2.AutoSize = true;
            o_player2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            o_player2.Location = new Point(170, 74);
            o_player2.Name = "o_player2";
            o_player2.Size = new Size(38, 26);
            o_player2.TabIndex = 52;
            o_player2.TabStop = true;
            o_player2.Text = "o";
            o_player2.TextAlign = ContentAlignment.MiddleCenter;
            o_player2.UseVisualStyleBackColor = true;
            o_player2.Click += x_player_Click;
            // 
            // x_player2
            // 
            x_player2.AutoSize = true;
            x_player2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            x_player2.Location = new Point(65, 74);
            x_player2.Name = "x_player2";
            x_player2.Size = new Size(37, 26);
            x_player2.TabIndex = 51;
            x_player2.TabStop = true;
            x_player2.Text = "x";
            x_player2.UseVisualStyleBackColor = true;
            x_player2.Click += x_player_Click;
            // 
            // player2_name
            // 
            player2_name.Location = new Point(115, 32);
            player2_name.Name = "player2_name";
            player2_name.PlaceholderText = "Name";
            player2_name.Size = new Size(134, 23);
            player2_name.TabIndex = 35;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(-411, 28);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 33;
            label2.Text = "player 2 : ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(o_player1);
            groupBox1.Controls.Add(x_player1);
            groupBox1.Controls.Add(player1_name);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(255, 120);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player 1";
            // 
            // o_player1
            // 
            o_player1.AutoSize = true;
            o_player1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            o_player1.Location = new Point(153, 74);
            o_player1.Name = "o_player1";
            o_player1.Size = new Size(38, 26);
            o_player1.TabIndex = 50;
            o_player1.TabStop = true;
            o_player1.Text = "o";
            o_player1.TextAlign = ContentAlignment.MiddleCenter;
            o_player1.UseVisualStyleBackColor = true;
            o_player1.Click += x_player_Click;
            // 
            // x_player1
            // 
            x_player1.AutoSize = true;
            x_player1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            x_player1.Location = new Point(48, 74);
            x_player1.Name = "x_player1";
            x_player1.Size = new Size(37, 26);
            x_player1.TabIndex = 35;
            x_player1.TabStop = true;
            x_player1.Text = "x";
            x_player1.UseVisualStyleBackColor = true;
            x_player1.Click += x_player_Click;
            // 
            // player1_name
            // 
            player1_name.Location = new Point(113, 32);
            player1_name.Name = "player1_name";
            player1_name.PlaceholderText = "Name";
            player1_name.Size = new Size(136, 23);
            player1_name.TabIndex = 34;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(-411, 28);
            label1.Name = "label1";
            label1.Size = new Size(105, 31);
            label1.TabIndex = 32;
            label1.Text = "player 1 : ";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(533, 461);
            Controls.Add(Registration_panal);
            Name = "Registration";
            Text = "Registration";
            Registration_panal.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Registration_panal;
        private Button button1;
        private GroupBox groupBox2;
        private RadioButton o_player2;
        private RadioButton x_player2;
        private TextBox player2_name;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton o_player1;
        private RadioButton x_player1;
        private TextBox player1_name;
        private Label label1;
    }
}