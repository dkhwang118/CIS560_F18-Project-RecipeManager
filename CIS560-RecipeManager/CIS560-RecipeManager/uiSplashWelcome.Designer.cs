namespace CIS560_RecipeManager
{
    partial class uiSplashWelcome
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
            this.uxTextBox_dboFileLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxTextBox_dboFileLocation
            // 
            this.uxTextBox_dboFileLocation.Location = new System.Drawing.Point(232, 879);
            this.uxTextBox_dboFileLocation.Name = "uxTextBox_dboFileLocation";
            this.uxTextBox_dboFileLocation.Size = new System.Drawing.Size(856, 31);
            this.uxTextBox_dboFileLocation.TabIndex = 0;
            // 
            // uiSplashWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 987);
            this.Controls.Add(this.uxTextBox_dboFileLocation);
            this.Name = "uiSplashWelcome";
            this.Text = "Welcome to Your Recipe Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextBox_dboFileLocation;
    }
}

