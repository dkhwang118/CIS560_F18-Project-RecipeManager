namespace CIS560_RecipeManager.RecipeManager
{
    partial class uiRecipeDetailForm
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
            this.RecipeNameLabel = new System.Windows.Forms.Label();
            this.RecipeDirectionTextBox = new System.Windows.Forms.TextBox();
            this.RecipeDirectionsLabel = new System.Windows.Forms.Label();
            this.RecipeDetailDGV = new System.Windows.Forms.DataGridView();
            this.RecipeIngredientsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDetailDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipeNameLabel
            // 
            this.RecipeNameLabel.AutoSize = true;
            this.RecipeNameLabel.Location = new System.Drawing.Point(33, 20);
            this.RecipeNameLabel.Name = "RecipeNameLabel";
            this.RecipeNameLabel.Size = new System.Drawing.Size(72, 13);
            this.RecipeNameLabel.TabIndex = 0;
            this.RecipeNameLabel.Text = "Recipe Name";
            // 
            // RecipeDirectionTextBox
            // 
            this.RecipeDirectionTextBox.Location = new System.Drawing.Point(36, 358);
            this.RecipeDirectionTextBox.Multiline = true;
            this.RecipeDirectionTextBox.Name = "RecipeDirectionTextBox";
            this.RecipeDirectionTextBox.ReadOnly = true;
            this.RecipeDirectionTextBox.Size = new System.Drawing.Size(520, 80);
            this.RecipeDirectionTextBox.TabIndex = 1;
            // 
            // RecipeDirectionsLabel
            // 
            this.RecipeDirectionsLabel.AutoSize = true;
            this.RecipeDirectionsLabel.Location = new System.Drawing.Point(33, 338);
            this.RecipeDirectionsLabel.Name = "RecipeDirectionsLabel";
            this.RecipeDirectionsLabel.Size = new System.Drawing.Size(57, 13);
            this.RecipeDirectionsLabel.TabIndex = 2;
            this.RecipeDirectionsLabel.Text = "Directions:";
            // 
            // RecipeDetailDGV
            // 
            this.RecipeDetailDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeDetailDGV.Location = new System.Drawing.Point(36, 85);
            this.RecipeDetailDGV.Name = "RecipeDetailDGV";
            this.RecipeDetailDGV.Size = new System.Drawing.Size(520, 224);
            this.RecipeDetailDGV.TabIndex = 3;
            // 
            // RecipeIngredientsLabel
            // 
            this.RecipeIngredientsLabel.AutoSize = true;
            this.RecipeIngredientsLabel.Location = new System.Drawing.Point(33, 57);
            this.RecipeIngredientsLabel.Name = "RecipeIngredientsLabel";
            this.RecipeIngredientsLabel.Size = new System.Drawing.Size(65, 13);
            this.RecipeIngredientsLabel.TabIndex = 4;
            this.RecipeIngredientsLabel.Text = "Ingredients: ";
            // 
            // uiRecipeDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.RecipeIngredientsLabel);
            this.Controls.Add(this.RecipeDetailDGV);
            this.Controls.Add(this.RecipeDirectionsLabel);
            this.Controls.Add(this.RecipeDirectionTextBox);
            this.Controls.Add(this.RecipeNameLabel);
            this.Name = "uiRecipeDetailForm";
            this.Text = "uiRecipeDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDetailDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecipeNameLabel;
        private System.Windows.Forms.TextBox RecipeDirectionTextBox;
        private System.Windows.Forms.Label RecipeDirectionsLabel;
        private System.Windows.Forms.DataGridView RecipeDetailDGV;
        private System.Windows.Forms.Label RecipeIngredientsLabel;
    }
}