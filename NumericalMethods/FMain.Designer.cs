namespace NumericalMethods
{
    partial class FMain
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
            this.btnOpenInputForm = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnFactorization = new System.Windows.Forms.Button();
            this.btnSLAQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenInputForm
            // 
            this.btnOpenInputForm.Location = new System.Drawing.Point(12, 12);
            this.btnOpenInputForm.Name = "btnOpenInputForm";
            this.btnOpenInputForm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenInputForm.TabIndex = 11;
            this.btnOpenInputForm.Text = "Input";
            this.btnOpenInputForm.UseVisualStyleBackColor = true;
            this.btnOpenInputForm.Click += new System.EventHandler(this.btnOpenInputForm_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(93, 14);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(687, 449);
            this.rtbOutput.TabIndex = 12;
            this.rtbOutput.Text = "";
            // 
            // btnFactorization
            // 
            this.btnFactorization.Location = new System.Drawing.Point(12, 55);
            this.btnFactorization.Name = "btnFactorization";
            this.btnFactorization.Size = new System.Drawing.Size(75, 23);
            this.btnFactorization.TabIndex = 13;
            this.btnFactorization.Text = "Factorization";
            this.btnFactorization.UseVisualStyleBackColor = true;
            this.btnFactorization.Click += new System.EventHandler(this.btnFactorization_Click);
            // 
            // btnSLAQ
            // 
            this.btnSLAQ.Location = new System.Drawing.Point(12, 84);
            this.btnSLAQ.Name = "btnSLAQ";
            this.btnSLAQ.Size = new System.Drawing.Size(75, 23);
            this.btnSLAQ.TabIndex = 14;
            this.btnSLAQ.Text = "SLAQ";
            this.btnSLAQ.UseVisualStyleBackColor = true;
            this.btnSLAQ.Click += new System.EventHandler(this.btnSLAQ_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 489);
            this.Controls.Add(this.btnSLAQ);
            this.Controls.Add(this.btnFactorization);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnOpenInputForm);
            this.Name = "FMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenInputForm;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnFactorization;
        private System.Windows.Forms.Button btnSLAQ;
    }
}

