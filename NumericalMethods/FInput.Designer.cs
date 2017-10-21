namespace NumericalMethods
{
    partial class FInput
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
            this.dgvPreviewMatrix = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnFromText = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnBadMatrix = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgTestVectorPreview = new System.Windows.Forms.DataGridView();
            this.tbTestVector = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestVectorPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreviewMatrix
            // 
            this.dgvPreviewMatrix.AllowUserToAddRows = false;
            this.dgvPreviewMatrix.AllowUserToDeleteRows = false;
            this.dgvPreviewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviewMatrix.Location = new System.Drawing.Point(315, 33);
            this.dgvPreviewMatrix.Name = "dgvPreviewMatrix";
            this.dgvPreviewMatrix.ReadOnly = true;
            this.dgvPreviewMatrix.Size = new System.Drawing.Size(324, 283);
            this.dgvPreviewMatrix.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preview";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(12, 33);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(297, 177);
            this.tbText.TabIndex = 2;
            // 
            // btnFromText
            // 
            this.btnFromText.Location = new System.Drawing.Point(198, 283);
            this.btnFromText.Name = "btnFromText";
            this.btnFromText.Size = new System.Drawing.Size(111, 23);
            this.btnFromText.TabIndex = 3;
            this.btnFromText.Text = "Generate from text";
            this.btnFromText.UseVisualStyleBackColor = true;
            this.btnFromText.Click += new System.EventHandler(this.btnFromText_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(578, 348);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(101, 23);
            this.btnRandom.TabIndex = 16;
            this.btnRandom.Text = "Generate random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnBadMatrix
            // 
            this.btnBadMatrix.Location = new System.Drawing.Point(685, 348);
            this.btnBadMatrix.Name = "btnBadMatrix";
            this.btnBadMatrix.Size = new System.Drawing.Size(75, 23);
            this.btnBadMatrix.TabIndex = 17;
            this.btnBadMatrix.Text = "плохообусл";
            this.btnBadMatrix.UseVisualStyleBackColor = true;
            this.btnBadMatrix.Click += new System.EventHandler(this.btnBadMatrix_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(685, 394);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(604, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Enter matrix from keyboard (use break \';\')";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(643, 322);
            this.nudSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(117, 20);
            this.nudSize.TabIndex = 21;
            this.nudSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Size";
            // 
            // dgTestVectorPreview
            // 
            this.dgTestVectorPreview.AllowUserToAddRows = false;
            this.dgTestVectorPreview.AllowUserToDeleteRows = false;
            this.dgTestVectorPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTestVectorPreview.Location = new System.Drawing.Point(645, 33);
            this.dgTestVectorPreview.Name = "dgTestVectorPreview";
            this.dgTestVectorPreview.ReadOnly = true;
            this.dgTestVectorPreview.Size = new System.Drawing.Size(115, 283);
            this.dgTestVectorPreview.TabIndex = 23;
            // 
            // tbTestVector
            // 
            this.tbTestVector.Location = new System.Drawing.Point(12, 229);
            this.tbTestVector.Multiline = true;
            this.tbTestVector.Name = "tbTestVector";
            this.tbTestVector.Size = new System.Drawing.Size(297, 48);
            this.tbTestVector.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "X preview";
            // 
            // FInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 427);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTestVector);
            this.Controls.Add(this.dgTestVectorPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnBadMatrix);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnFromText);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPreviewMatrix);
            this.Name = "FInput";
            this.Text = "FInput";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestVectorPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreviewMatrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnFromText;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnBadMatrix;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgTestVectorPreview;
        private System.Windows.Forms.TextBox tbTestVector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}