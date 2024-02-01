namespace tic_tac_toc_game
{
    partial class score_table
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
            score_dgv = new DataGridView();
            label1 = new Label();
            delete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)score_dgv).BeginInit();
            SuspendLayout();
            // 
            // score_dgv
            // 
            score_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            score_dgv.Location = new Point(12, 93);
            score_dgv.Name = "score_dgv";
            score_dgv.Size = new Size(509, 356);
            score_dgv.TabIndex = 0;
            score_dgv.RowHeaderMouseDoubleClick += score_dgv_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14.25F);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "Scores";
            // 
            // delete_btn
            // 
            delete_btn.Anchor = AnchorStyles.Top;
            delete_btn.BackColor = Color.Crimson;
            delete_btn.Font = new Font("Snap ITC", 14.25F);
            delete_btn.ForeColor = SystemColors.ActiveCaptionText;
            delete_btn.Location = new Point(422, 49);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(99, 38);
            delete_btn.TabIndex = 39;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // score_table
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(533, 461);
            Controls.Add(delete_btn);
            Controls.Add(label1);
            Controls.Add(score_dgv);
            Name = "score_table";
            Text = "score_table";
            ((System.ComponentModel.ISupportInitialize)score_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView score_dgv;
        private Label label1;
        private Button delete_btn;
    }
}