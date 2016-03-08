namespace Windows_Sleep_Timer
{
    partial class SleepTimer
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
            this.hoursLbl = new System.Windows.Forms.Label();
            this.hoursInput = new System.Windows.Forms.NumericUpDown();
            this.minutesLbl = new System.Windows.Forms.Label();
            this.minutesField = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.secondsField = new System.Windows.Forms.NumericUpDown();
            this.sleepBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hoursInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsField)).BeginInit();
            this.SuspendLayout();
            // 
            // hoursLbl
            // 
            this.hoursLbl.AutoSize = true;
            this.hoursLbl.Location = new System.Drawing.Point(12, 9);
            this.hoursLbl.Name = "hoursLbl";
            this.hoursLbl.Size = new System.Drawing.Size(35, 13);
            this.hoursLbl.TabIndex = 0;
            this.hoursLbl.Text = "Hours";
            // 
            // hoursInput
            // 
            this.hoursInput.Location = new System.Drawing.Point(15, 24);
            this.hoursInput.Name = "hoursInput";
            this.hoursInput.Size = new System.Drawing.Size(35, 20);
            this.hoursInput.TabIndex = 1;
            this.hoursInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // minutesLbl
            // 
            this.minutesLbl.AutoSize = true;
            this.minutesLbl.Location = new System.Drawing.Point(65, 9);
            this.minutesLbl.Name = "minutesLbl";
            this.minutesLbl.Size = new System.Drawing.Size(44, 13);
            this.minutesLbl.TabIndex = 2;
            this.minutesLbl.Text = "Minutes";
            // 
            // minutesField
            // 
            this.minutesField.Location = new System.Drawing.Point(68, 24);
            this.minutesField.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesField.Name = "minutesField";
            this.minutesField.Size = new System.Drawing.Size(35, 20);
            this.minutesField.TabIndex = 3;
            this.minutesField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seconds";
            // 
            // secondsField
            // 
            this.secondsField.Location = new System.Drawing.Point(122, 24);
            this.secondsField.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondsField.Name = "secondsField";
            this.secondsField.Size = new System.Drawing.Size(35, 20);
            this.secondsField.TabIndex = 5;
            this.secondsField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sleepBtn
            // 
            this.sleepBtn.Location = new System.Drawing.Point(180, 22);
            this.sleepBtn.Name = "sleepBtn";
            this.sleepBtn.Size = new System.Drawing.Size(60, 23);
            this.sleepBtn.TabIndex = 6;
            this.sleepBtn.Text = "Sleep";
            this.sleepBtn.UseVisualStyleBackColor = true;
            this.sleepBtn.Click += new System.EventHandler(this.sleepBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(180, 22);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(60, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SleepTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 51);
            this.Controls.Add(this.secondsField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minutesField);
            this.Controls.Add(this.minutesLbl);
            this.Controls.Add(this.hoursInput);
            this.Controls.Add(this.hoursLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sleepBtn);
            this.MaximumSize = new System.Drawing.Size(280, 90);
            this.MinimumSize = new System.Drawing.Size(280, 90);
            this.Name = "SleepTimer";
            this.Text = "Sleep Timer";
            ((System.ComponentModel.ISupportInitialize)(this.hoursInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoursLbl;
        private System.Windows.Forms.NumericUpDown hoursInput;
        private System.Windows.Forms.Label minutesLbl;
        private System.Windows.Forms.NumericUpDown minutesField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown secondsField;
        private System.Windows.Forms.Button sleepBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}

