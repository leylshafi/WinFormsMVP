namespace WinFormsApp1.Views
{
    partial class UpdateView
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.ScoreNm = new System.Windows.Forms.NumericUpDown();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreNm)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(244, 13);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(13, 233);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(227, 41);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(249, 233);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(227, 41);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ScoreNm
            // 
            this.ScoreNm.DecimalPlaces = 1;
            this.ScoreNm.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScoreNm.Location = new System.Drawing.Point(14, 135);
            this.ScoreNm.Margin = new System.Windows.Forms.Padding(4);
            this.ScoreNm.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.ScoreNm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScoreNm.Name = "ScoreNm";
            this.ScoreNm.Size = new System.Drawing.Size(193, 23);
            this.ScoreNm.TabIndex = 9;
            this.ScoreNm.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(13, 75);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.PlaceholderText = "Last name";
            this.txt_LastName.Size = new System.Drawing.Size(193, 23);
            this.txt_LastName.TabIndex = 8;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(13, 13);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.PlaceholderText = "First name";
            this.txt_FirstName.Size = new System.Drawing.Size(193, 23);
            this.txt_FirstName.TabIndex = 7;
            // 
            // UpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 297);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.ScoreNm);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Name = "UpdateView";
            this.Text = "UpdateView";
            ((System.ComponentModel.ISupportInitialize)(this.ScoreNm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button btn_save;
        private Button btn_cancel;
        private NumericUpDown ScoreNm;
        private TextBox txt_LastName;
        private TextBox txt_FirstName;
    }
}