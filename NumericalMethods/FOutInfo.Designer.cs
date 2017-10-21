namespace NumericalMethods
{
    partial class FOutInfo
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
            this.rtbOutInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbOutInfo
            // 
            this.rtbOutInfo.Location = new System.Drawing.Point(12, 12);
            this.rtbOutInfo.Name = "rtbOutInfo";
            this.rtbOutInfo.Size = new System.Drawing.Size(440, 453);
            this.rtbOutInfo.TabIndex = 0;
            this.rtbOutInfo.Text = "";
            // 
            // FOutInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 477);
            this.Controls.Add(this.rtbOutInfo);
            this.Name = "FOutInfo";
            this.Text = "FOutInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutInfo;
    }
}