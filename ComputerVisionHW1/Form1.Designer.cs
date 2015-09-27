namespace ComputerVisionHW1
{
    partial class Form1
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
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.TurnBlackButton = new System.Windows.Forms.Button();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.WidthVariableLabel = new System.Windows.Forms.Label();
            this.WidthVariable = new System.Windows.Forms.TextBox();
            this.HeighVariableLabel = new System.Windows.Forms.Label();
            this.HeightVariable = new System.Windows.Forms.TextBox();
            this.RotateVariable = new System.Windows.Forms.TextBox();
            this.RotateVariableLable = new System.Windows.Forms.Label();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XMovement = new System.Windows.Forms.TextBox();
            this.YMovement = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Location = new System.Drawing.Point(182, 12);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(701, 402);
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // TurnBlackButton
            // 
            this.TurnBlackButton.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnBlackButton.Location = new System.Drawing.Point(13, 74);
            this.TurnBlackButton.Name = "TurnBlackButton";
            this.TurnBlackButton.Size = new System.Drawing.Size(164, 46);
            this.TurnBlackButton.TabIndex = 1;
            this.TurnBlackButton.Text = "黑化";
            this.TurnBlackButton.UseVisualStyleBackColor = true;
            this.TurnBlackButton.Click += new System.EventHandler(this.TurnBlackButton_Click);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadImageButton.Location = new System.Drawing.Point(13, 12);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(163, 46);
            this.LoadImageButton.TabIndex = 2;
            this.LoadImageButton.Text = "讀取圖片";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // WidthVariableLabel
            // 
            this.WidthVariableLabel.AutoSize = true;
            this.WidthVariableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthVariableLabel.Location = new System.Drawing.Point(12, 209);
            this.WidthVariableLabel.Name = "WidthVariableLabel";
            this.WidthVariableLabel.Size = new System.Drawing.Size(102, 25);
            this.WidthVariableLabel.TabIndex = 3;
            this.WidthVariableLabel.Text = "拉申寬度:";
            // 
            // WidthVariable
            // 
            this.WidthVariable.Location = new System.Drawing.Point(120, 215);
            this.WidthVariable.Name = "WidthVariable";
            this.WidthVariable.Size = new System.Drawing.Size(56, 20);
            this.WidthVariable.TabIndex = 4;
            this.WidthVariable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthVariable_KeyPress);
            // 
            // HeighVariableLabel
            // 
            this.HeighVariableLabel.AutoSize = true;
            this.HeighVariableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeighVariableLabel.Location = new System.Drawing.Point(12, 251);
            this.HeighVariableLabel.Name = "HeighVariableLabel";
            this.HeighVariableLabel.Size = new System.Drawing.Size(102, 25);
            this.HeighVariableLabel.TabIndex = 5;
            this.HeighVariableLabel.Text = "拉申高度:";
            // 
            // HeightVariable
            // 
            this.HeightVariable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.HeightVariable.Location = new System.Drawing.Point(120, 257);
            this.HeightVariable.Name = "HeightVariable";
            this.HeightVariable.Size = new System.Drawing.Size(56, 20);
            this.HeightVariable.TabIndex = 6;
            this.HeightVariable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightVariable_KeyPress);
            // 
            // RotateVariable
            // 
            this.RotateVariable.Location = new System.Drawing.Point(120, 299);
            this.RotateVariable.Name = "RotateVariable";
            this.RotateVariable.Size = new System.Drawing.Size(56, 20);
            this.RotateVariable.TabIndex = 7;
            this.RotateVariable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RotateVariable_KeyPress);
            // 
            // RotateVariableLable
            // 
            this.RotateVariableLable.AutoSize = true;
            this.RotateVariableLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateVariableLable.Location = new System.Drawing.Point(12, 293);
            this.RotateVariableLable.Name = "RotateVariableLable";
            this.RotateVariableLable.Size = new System.Drawing.Size(102, 25);
            this.RotateVariableLable.TabIndex = 8;
            this.RotateVariableLable.Text = "旋轉角度:";
            // 
            // ProcessButton
            // 
            this.ProcessButton.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessButton.Location = new System.Drawing.Point(13, 334);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(163, 46);
            this.ProcessButton.TabIndex = 9;
            this.ProcessButton.Text = "開始處理";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "橫向平移:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "縱向平移:";
            // 
            // XMovement
            // 
            this.XMovement.Location = new System.Drawing.Point(121, 143);
            this.XMovement.Name = "XMovement";
            this.XMovement.Size = new System.Drawing.Size(55, 20);
            this.XMovement.TabIndex = 12;
            this.XMovement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XMovement_KeyPress);
            // 
            // YMovement
            // 
            this.YMovement.Location = new System.Drawing.Point(121, 178);
            this.YMovement.Name = "YMovement";
            this.YMovement.Size = new System.Drawing.Size(55, 20);
            this.YMovement.TabIndex = 13;
            this.YMovement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.YMovement_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 445);
            this.Controls.Add(this.YMovement);
            this.Controls.Add(this.XMovement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.RotateVariableLable);
            this.Controls.Add(this.RotateVariable);
            this.Controls.Add(this.HeightVariable);
            this.Controls.Add(this.HeighVariableLabel);
            this.Controls.Add(this.WidthVariable);
            this.Controls.Add(this.WidthVariableLabel);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.TurnBlackButton);
            this.Controls.Add(this.MainPictureBox);
            this.Name = "Form1";
            this.Text = "ComputerVisionHW1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Button TurnBlackButton;
        private System.Windows.Forms.Button LoadImageButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label WidthVariableLabel;
        private System.Windows.Forms.TextBox WidthVariable;
        private System.Windows.Forms.TextBox HeightVariable;
        private System.Windows.Forms.Label HeighVariableLabel;
        private System.Windows.Forms.Label RotateVariableLable;
        private System.Windows.Forms.TextBox RotateVariable;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.TextBox YMovement;
        private System.Windows.Forms.TextBox XMovement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

