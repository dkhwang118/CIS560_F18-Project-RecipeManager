namespace CIS560_RecipeManager.StatsFormManager
{
    partial class uiRecipeRatingsForm
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
            this.components = new System.ComponentModel.Container();
            this.uxButton_GetTopRatedRecipesPerCategory = new System.Windows.Forms.Button();
            this.uxLabel_GetTopRatedRecipesPerCategory = new System.Windows.Forms.Label();
            this.uxLabel_GetTopRatedRecipesPerCategory2ndHalf = new System.Windows.Forms.Label();
            this.uxTextBox_AmtPerCategoryToReturn = new System.Windows.Forms.TextBox();
            this.uxDGV_RecipeRatingOutput = new System.Windows.Forms.DataGridView();
            this.RecipeRatingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uxButton_GetAvgRecpieRatingPerCat = new System.Windows.Forms.Button();
            this.uxLabel_GetAvgRecipeRatingPerCat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxDGV_RecipeRatingOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeRatingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxButton_GetTopRatedRecipesPerCategory
            // 
            this.uxButton_GetTopRatedRecipesPerCategory.Location = new System.Drawing.Point(398, 26);
            this.uxButton_GetTopRatedRecipesPerCategory.Margin = new System.Windows.Forms.Padding(2);
            this.uxButton_GetTopRatedRecipesPerCategory.Name = "uxButton_GetTopRatedRecipesPerCategory";
            this.uxButton_GetTopRatedRecipesPerCategory.Size = new System.Drawing.Size(84, 35);
            this.uxButton_GetTopRatedRecipesPerCategory.TabIndex = 0;
            this.uxButton_GetTopRatedRecipesPerCategory.Text = "Get Recipes";
            this.uxButton_GetTopRatedRecipesPerCategory.UseVisualStyleBackColor = true;
            this.uxButton_GetTopRatedRecipesPerCategory.Click += new System.EventHandler(this.uxButton_GetTopRatedRecipesPerCategory_Click);
            // 
            // uxLabel_GetTopRatedRecipesPerCategory
            // 
            this.uxLabel_GetTopRatedRecipesPerCategory.AutoSize = true;
            this.uxLabel_GetTopRatedRecipesPerCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel_GetTopRatedRecipesPerCategory.Location = new System.Drawing.Point(14, 32);
            this.uxLabel_GetTopRatedRecipesPerCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLabel_GetTopRatedRecipesPerCategory.Name = "uxLabel_GetTopRatedRecipesPerCategory";
            this.uxLabel_GetTopRatedRecipesPerCategory.Size = new System.Drawing.Size(67, 20);
            this.uxLabel_GetTopRatedRecipesPerCategory.TabIndex = 1;
            this.uxLabel_GetTopRatedRecipesPerCategory.Text = "Get Top";
            // 
            // uxLabel_GetTopRatedRecipesPerCategory2ndHalf
            // 
            this.uxLabel_GetTopRatedRecipesPerCategory2ndHalf.AutoSize = true;
            this.uxLabel_GetTopRatedRecipesPerCategory2ndHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel_GetTopRatedRecipesPerCategory2ndHalf.Location = new System.Drawing.Point(114, 32);
            this.uxLabel_GetTopRatedRecipesPerCategory2ndHalf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLabel_GetTopRatedRecipesPerCategory2ndHalf.Name = "uxLabel_GetTopRatedRecipesPerCategory2ndHalf";
            this.uxLabel_GetTopRatedRecipesPerCategory2ndHalf.Size = new System.Drawing.Size(264, 20);
            this.uxLabel_GetTopRatedRecipesPerCategory2ndHalf.TabIndex = 2;
            this.uxLabel_GetTopRatedRecipesPerCategory2ndHalf.Text = "Rated Recipes per Recipe Category";
            // 
            // uxTextBox_AmtPerCategoryToReturn
            // 
            this.uxTextBox_AmtPerCategoryToReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBox_AmtPerCategoryToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBox_AmtPerCategoryToReturn.Location = new System.Drawing.Point(85, 29);
            this.uxTextBox_AmtPerCategoryToReturn.Margin = new System.Windows.Forms.Padding(2);
            this.uxTextBox_AmtPerCategoryToReturn.Name = "uxTextBox_AmtPerCategoryToReturn";
            this.uxTextBox_AmtPerCategoryToReturn.Size = new System.Drawing.Size(25, 26);
            this.uxTextBox_AmtPerCategoryToReturn.TabIndex = 3;
            this.uxTextBox_AmtPerCategoryToReturn.Text = "5";
            this.uxTextBox_AmtPerCategoryToReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxDGV_RecipeRatingOutput
            // 
            this.uxDGV_RecipeRatingOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDGV_RecipeRatingOutput.Location = new System.Drawing.Point(495, 11);
            this.uxDGV_RecipeRatingOutput.Margin = new System.Windows.Forms.Padding(2);
            this.uxDGV_RecipeRatingOutput.Name = "uxDGV_RecipeRatingOutput";
            this.uxDGV_RecipeRatingOutput.RowTemplate.Height = 33;
            this.uxDGV_RecipeRatingOutput.Size = new System.Drawing.Size(338, 430);
            this.uxDGV_RecipeRatingOutput.TabIndex = 4;
            // 
            // uxButton_GetAvgRecpieRatingPerCat
            // 
            this.uxButton_GetAvgRecpieRatingPerCat.Location = new System.Drawing.Point(398, 92);
            this.uxButton_GetAvgRecpieRatingPerCat.Margin = new System.Windows.Forms.Padding(2);
            this.uxButton_GetAvgRecpieRatingPerCat.Name = "uxButton_GetAvgRecpieRatingPerCat";
            this.uxButton_GetAvgRecpieRatingPerCat.Size = new System.Drawing.Size(84, 35);
            this.uxButton_GetAvgRecpieRatingPerCat.TabIndex = 5;
            this.uxButton_GetAvgRecpieRatingPerCat.Text = "Get Recipes";
            this.uxButton_GetAvgRecpieRatingPerCat.UseVisualStyleBackColor = true;
            this.uxButton_GetAvgRecpieRatingPerCat.Click += new System.EventHandler(this.uxButton_GetAvgRecpieRatingPerCat_Click);
            // 
            // uxLabel_GetAvgRecipeRatingPerCat
            // 
            this.uxLabel_GetAvgRecipeRatingPerCat.AutoSize = true;
            this.uxLabel_GetAvgRecipeRatingPerCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel_GetAvgRecipeRatingPerCat.Location = new System.Drawing.Point(14, 98);
            this.uxLabel_GetAvgRecipeRatingPerCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLabel_GetAvgRecipeRatingPerCat.Name = "uxLabel_GetAvgRecipeRatingPerCat";
            this.uxLabel_GetAvgRecipeRatingPerCat.Size = new System.Drawing.Size(380, 20);
            this.uxLabel_GetAvgRecipeRatingPerCat.TabIndex = 6;
            this.uxLabel_GetAvgRecipeRatingPerCat.Text = "Get the Average Recipe Rating per Recipe Category";
            // 
            // uiRecipeRatingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 454);
            this.Controls.Add(this.uxLabel_GetAvgRecipeRatingPerCat);
            this.Controls.Add(this.uxButton_GetAvgRecpieRatingPerCat);
            this.Controls.Add(this.uxDGV_RecipeRatingOutput);
            this.Controls.Add(this.uxTextBox_AmtPerCategoryToReturn);
            this.Controls.Add(this.uxLabel_GetTopRatedRecipesPerCategory2ndHalf);
            this.Controls.Add(this.uxLabel_GetTopRatedRecipesPerCategory);
            this.Controls.Add(this.uxButton_GetTopRatedRecipesPerCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "uiRecipeRatingsForm";
            this.Text = "Recipe Ratings";
            ((System.ComponentModel.ISupportInitialize)(this.uxDGV_RecipeRatingOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeRatingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxButton_GetTopRatedRecipesPerCategory;
        private System.Windows.Forms.Label uxLabel_GetTopRatedRecipesPerCategory;
        private System.Windows.Forms.Label uxLabel_GetTopRatedRecipesPerCategory2ndHalf;
        private System.Windows.Forms.DataGridView uxDGV_RecipeRatingOutput;
        private System.Windows.Forms.BindingSource RecipeRatingsBindingSource;
        public System.Windows.Forms.TextBox uxTextBox_AmtPerCategoryToReturn;
        private System.Windows.Forms.Button uxButton_GetAvgRecpieRatingPerCat;
        private System.Windows.Forms.Label uxLabel_GetAvgRecipeRatingPerCat;
    }
}