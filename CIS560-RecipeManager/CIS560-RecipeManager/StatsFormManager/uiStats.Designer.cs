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
            this.uxButton_WhatCanIMake = new System.Windows.Forms.Button();
            this.uxButton_RecipesNotCookedRecent = new System.Windows.Forms.Button();
            this.uxButton_RecipeRatings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxButton_WhatCanIMake
            // 
            this.uxButton_WhatCanIMake.Location = new System.Drawing.Point(46, 30);
            this.uxButton_WhatCanIMake.Name = "uxButton_WhatCanIMake";
            this.uxButton_WhatCanIMake.Size = new System.Drawing.Size(311, 52);
            this.uxButton_WhatCanIMake.TabIndex = 0;
            this.uxButton_WhatCanIMake.Text = "What can I make with my current pantry?";
            this.uxButton_WhatCanIMake.UseVisualStyleBackColor = true;
            this.uxButton_WhatCanIMake.Click += new System.EventHandler(this.uxButton_WhatCanIMake_Click);
            // 
            // uxButton_RecipesNotCookedRecent
            // 
            this.uxButton_RecipesNotCookedRecent.Location = new System.Drawing.Point(46, 100);
            this.uxButton_RecipesNotCookedRecent.Name = "uxButton_RecipesNotCookedRecent";
            this.uxButton_RecipesNotCookedRecent.Size = new System.Drawing.Size(311, 52);
            this.uxButton_RecipesNotCookedRecent.TabIndex = 1;
            this.uxButton_RecipesNotCookedRecent.Text = "What have I not cooked lately?";
            this.uxButton_RecipesNotCookedRecent.UseVisualStyleBackColor = true;
            this.uxButton_RecipesNotCookedRecent.Click += new System.EventHandler(this.uxButton_RecipesNotCookedRecent_Click);
            // 
            // uxButton_RecipeRatings
            // 
            this.uxButton_RecipeRatings.Location = new System.Drawing.Point(46, 173);
            this.uxButton_RecipeRatings.Name = "uxButton_RecipeRatings";
            this.uxButton_RecipeRatings.Size = new System.Drawing.Size(311, 52);
            this.uxButton_RecipeRatings.TabIndex = 2;
            this.uxButton_RecipeRatings.Text = "Recipe Ratings";
            this.uxButton_RecipeRatings.UseVisualStyleBackColor = true;
            this.uxButton_RecipeRatings.Click += new System.EventHandler(this.uxButton_RecipeRatings_Click);
            // 
            // uiStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 262);
            this.Controls.Add(this.uxButton_RecipeRatings);
            this.Controls.Add(this.uxButton_RecipesNotCookedRecent);
            this.Controls.Add(this.uxButton_WhatCanIMake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "uiStats";
            this.Text = "Extra Features and Information";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxButton_WhatCanIMake;
        private System.Windows.Forms.Button uxButton_RecipesNotCookedRecent;
        private System.Windows.Forms.Button uxButton_RecipeRatings;
    }
}