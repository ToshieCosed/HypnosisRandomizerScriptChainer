namespace HypnosisRandomizer
{
    partial class Feature_Not_Implemented
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feature_Not_Implemented));
            this.FeatureNotImplementedTextBox = new System.Windows.Forms.RichTextBox();
            this.Okay_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FeatureNotImplementedTextBox
            // 
            this.FeatureNotImplementedTextBox.Location = new System.Drawing.Point(13, 13);
            this.FeatureNotImplementedTextBox.Name = "FeatureNotImplementedTextBox";
            this.FeatureNotImplementedTextBox.ReadOnly = true;
            this.FeatureNotImplementedTextBox.Size = new System.Drawing.Size(287, 86);
            this.FeatureNotImplementedTextBox.TabIndex = 0;
            this.FeatureNotImplementedTextBox.Text = resources.GetString("FeatureNotImplementedTextBox.Text");
            // 
            // Okay_Button
            // 
            this.Okay_Button.Location = new System.Drawing.Point(191, 105);
            this.Okay_Button.Name = "Okay_Button";
            this.Okay_Button.Size = new System.Drawing.Size(109, 37);
            this.Okay_Button.TabIndex = 1;
            this.Okay_Button.Text = "Okay";
            this.Okay_Button.UseVisualStyleBackColor = true;
            this.Okay_Button.Click += new System.EventHandler(this.Okay_Button_Click);
            // 
            // Feature_Not_Implemented
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 154);
            this.Controls.Add(this.Okay_Button);
            this.Controls.Add(this.FeatureNotImplementedTextBox);
            this.Name = "Feature_Not_Implemented";
            this.Text = "Feature_Not_Implemented";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox FeatureNotImplementedTextBox;
        private System.Windows.Forms.Button Okay_Button;
    }
}