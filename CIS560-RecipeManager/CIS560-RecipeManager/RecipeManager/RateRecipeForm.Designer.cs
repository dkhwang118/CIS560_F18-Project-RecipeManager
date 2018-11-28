namespace CIS560_RecipeManager.RecipeManager
{
    partial class RateRecipeForm
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
            this.uxRatingSelector = new System.Windows.Forms.NumericUpDown();
            this.rateRecipeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxRatingSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // uxRatingSelector
            // 
            this.uxRatingSelector.Location = new System.Drawing.Point(110, 36);
            this.uxRatingSelector.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.uxRatingSelector.Name = "uxRatingSelector";
            this.uxRatingSelector.Size = new System.Drawing.Size(120, 20);
            this.uxRatingSelector.TabIndex = 0;
            // 
            // rateRecipeButton
            // 
            this.rateRecipeButton.Location = new System.Drawing.Point(110, 75);
            this.rateRecipeButton.Name = "rateRecipeButton";
            this.rateRecipeButton.Size = new System.Drawing.Size(120, 43);
            this.rateRecipeButton.TabIndex = 1;
            this.rateRecipeButton.Text = "Rate Recipe";
            this.rateRecipeButton.UseVisualStyleBackColor = true;
            this.rateRecipeButton.Click += new System.EventHandler(this.rateRecipeButton_Click);
            // 
            // RateRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 130);
            this.Controls.Add(this.rateRecipeButton);
            this.Controls.Add(this.uxRatingSelector);
            this.Name = "RateRecipeForm";
            this.Text = "RateRecipeForm";
            ((System.ComponentModel.ISupportInitialize)(this.uxRatingSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown uxRatingSelector;
        private System.Windows.Forms.Button rateRecipeButton;
    }
}