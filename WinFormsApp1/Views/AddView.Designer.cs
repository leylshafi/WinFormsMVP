namespace WinFormsApp1.Views
{
    partial class AddView
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
            this.txt_Fistname = new System.Windows.Forms.TextBox();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.NmScore = new System.Windows.Forms.NumericUpDown();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.NmScore)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Fistname
            // 
            this.txt_Fistname.Location = new System.Drawing.Point(13, 23);
            this.txt_Fistname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Fistname.Name = "txt_Fistname";
            this.txt_Fistname.PlaceholderText = "First name";
            this.txt_Fistname.Size = new System.Drawing.Size(193, 29);
            this.txt_Fistname.TabIndex = 0;
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Location = new System.Drawing.Point(13, 85);
            this.txt_Lastname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.PlaceholderText = "Last name";
            this.txt_Lastname.Size = new System.Drawing.Size(193, 29);
            this.txt_Lastname.TabIndex = 1;
            // 
            // NmScore
            // 
            this.NmScore.DecimalPlaces = 1;
            this.NmScore.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NmScore.Location = new System.Drawing.Point(14, 145);
            this.NmScore.Margin = new System.Windows.Forms.Padding(4);
            this.NmScore.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NmScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmScore.Name = "NmScore";
            this.NmScore.Size = new System.Drawing.Size(193, 29);
            this.NmScore.TabIndex = 2;
            this.NmScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(249, 243);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(227, 41);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(13, 243);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(227, 41);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(244, 23);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 336);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.NmScore);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_Fistname);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddView";
            this.Text = "AddView";
            ((System.ComponentModel.ISupportInitialize)(this.NmScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Fistname;
        private TextBox txt_Lastname;
        private NumericUpDown NmScore;
        private Button btn_cancel;
        private Button btn_save;
        private MonthCalendar monthCalendar1;
    }
}