namespace ScreenshotBuddy
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
            this.takeScreenshot = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // takeScreenshot
            // 
            this.takeScreenshot.Location = new System.Drawing.Point(12, 12);
            this.takeScreenshot.Name = "takeScreenshot";
            this.takeScreenshot.Size = new System.Drawing.Size(131, 52);
            this.takeScreenshot.TabIndex = 0;
            this.takeScreenshot.Text = "Take Screenshot";
            this.takeScreenshot.UseVisualStyleBackColor = true;
            this.takeScreenshot.Click += new System.EventHandler(this.takeScreenshot_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(115, 70);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 99);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.takeScreenshot);
            this.Name = "Form1";
            this.Text = "ScreenshotBuddy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button takeScreenshot;
        private System.Windows.Forms.Button closeButton;
    }
}

