namespace TubeRouteFinder
{
    partial class loadFileForm
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
            this.EnteraNameLabel = new System.Windows.Forms.Label();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fileNotFoundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnteraNameLabel
            // 
            this.EnteraNameLabel.AutoSize = true;
            this.EnteraNameLabel.Location = new System.Drawing.Point(12, 9);
            this.EnteraNameLabel.Name = "EnteraNameLabel";
            this.EnteraNameLabel.Size = new System.Drawing.Size(95, 13);
            this.EnteraNameLabel.TabIndex = 0;
            this.EnteraNameLabel.Text = "Enter the Filename";
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(15, 25);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(312, 20);
            this.fileNameBox.TabIndex = 1;
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(252, 58);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(75, 23);
            this.loadFileButton.TabIndex = 2;
            this.loadFileButton.Text = "Load";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(15, 58);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // fileNotFoundLabel
            // 
            this.fileNotFoundLabel.AutoSize = true;
            this.fileNotFoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fileNotFoundLabel.Location = new System.Drawing.Point(118, 63);
            this.fileNotFoundLabel.Name = "fileNotFoundLabel";
            this.fileNotFoundLabel.Size = new System.Drawing.Size(0, 13);
            this.fileNotFoundLabel.TabIndex = 4;
            // 
            // loadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 93);
            this.Controls.Add(this.fileNotFoundLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.EnteraNameLabel);
            this.Name = "loadFileForm";
            this.Text = "Load a Route";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnteraNameLabel;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label fileNotFoundLabel;
    }
}