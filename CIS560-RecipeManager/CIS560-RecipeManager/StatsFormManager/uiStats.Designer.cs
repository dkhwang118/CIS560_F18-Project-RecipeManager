namespace CIS560_RecipeManager.StatsFormManager
{
    partial class uiStats
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
            this.uxButton_RecipesNotCookedRecent = new System.Windows.Forms.Button();
            this.uxButton_RecipeRatings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxButton_RecipesNotCookedRecent
            // 
            this.uxButton_RecipesNotCookedRecent.Location = new System.Drawing.Point(92, 54);
            this.uxButton_RecipesNotCookedRecent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxButton_RecipesNotCookedRecent.Name = "uxButton_RecipesNotCookedRecent";
            this.uxButton_RecipesNotCookedRecent.Size = new System.Drawing.Size(622, 100);
            this.uxButton_RecipesNotCookedRecent.TabIndex = 1;
            this.uxButton_RecipesNotCookedRecent.Text = "What have I not cooked lately?";
            this.uxButton_RecipesNotCookedRecent.UseVisualStyleBackColor = true;
            this.uxButton_RecipesNotCookedRecent.Click += new System.EventHandler(this.uxButton_RecipesNotCookedRecent_Click);
            // 
            // uxButton_RecipeRatings
            // 
            this.uxButton_RecipeRatings.Location = new System.Drawing.Point(92, 221);
            this.uxButton_RecipeRatings.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.uxButton_RecipeRatings.Name = "uxButton_RecipeRatings";
            this.uxButton_RecipeRatings.Size = new System.Drawing.Size(622, 100);
            this.uxButton_RecipeRatings.TabIndex = 2;
            this.uxButton_RecipeRatings.Text = "Recipe Ratings";
            this.uxButton_RecipeRatings.UseVisualStyleBackColor = true;
            this.uxButton_RecipeRatings.Click += new System.EventHandler(this.uxButton_RecipeRatings_Click);
            // 
            // uiStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 392);
            this.Controls.Add(this.uxButton_RecipeRatings);
            this.Controls.Add(this.uxButton_RecipesNotCookedRecent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "uiStats";
            this.Text = "Extra Features and Information";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button uxButton_RecipesNotCookedRecent;
        private System.Windows.Forms.Button uxButton_RecipeRatings;
    }
}