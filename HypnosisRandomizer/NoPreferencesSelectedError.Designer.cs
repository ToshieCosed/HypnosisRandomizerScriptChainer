namespace HypnosisRandomizer
{
    partial class NoPreferencesSelectedError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoPreferencesSelectedError));
            this.ErrorTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorTextBox
            // 
            this.ErrorTextBox.Location = new System.Drawing.Point(13, 13);
            this.ErrorTextBox.Name = "ErrorTextBox";
            this.ErrorTextBox.ReadOnly = true;
            this.ErrorTextBox.Size = new System.Drawing.Size(362, 133);
            this.ErrorTextBox.TabIndex = 0;
            this.ErrorTextBox.Text = resources.GetString("ErrorTextBox.Text");
            // 
            // ButtonOkay
            // 
            this.ButtonOkay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonOkay.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonOkay.Location = new System.Drawing.Point(283, 173);
            this.ButtonOkay.Name = "ButtonOkay";
            this.ButtonOkay.Size = new System.Drawing.Size(92, 50);
            this.ButtonOkay.TabIndex = 1;
            this.ButtonOkay.Text = "Okay";
            this.ButtonOkay.UseVisualStyleBackColor = false;
            this.ButtonOkay.Click += new System.EventHandler(this.ButtonOkay_Click);
            // 
            // NoPreferencesSelectedError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 235);
            this.Controls.Add(this.ButtonOkay);
            this.Controls.Add(this.ErrorTextBox);
            this.Name = "NoPreferencesSelectedError";
            this.Text = "NoPreferencesSelectedError";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ErrorTextBox;
        private System.Windows.Forms.Button ButtonOkay;
    }
}