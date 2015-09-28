namespace ComputerVisionHW1
{
    partial class Form2
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
            this.ResultPictureBox = new System.Windows.Forms.PictureBox();
            this.Compare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultPictureBox
            // 
            this.ResultPictureBox.Location = new System.Drawing.Point(13, 25);
            this.ResultPictureBox.Name = "ResultPictureBox";
            this.ResultPictureBox.Size = new System.Drawing.Size(1249, 614);
            this.ResultPictureBox.TabIndex = 0;
            this.ResultPictureBox.TabStop = false;
            // 
            // Compare
            // 
            this.Compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compare.Location = new System.Drawing.Point(13, 1);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(17, 18);
            this.Compare.TabIndex = 1;
            this.Compare.Text = "　";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 736);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.ResultPictureBox);
            this.Name = "Form2";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ResultPictureBox;
        private System.Windows.Forms.Button Compare;
    }
}