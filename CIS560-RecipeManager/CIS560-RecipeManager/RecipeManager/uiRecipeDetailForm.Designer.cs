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
            this.components = new System.ComponentModel.Container();
            this.RecipeNameLabel = new System.Windows.Forms.Label();
            this.RecipeDirectionTextBox = new System.Windows.Forms.TextBox();
            this.RecipeDirectionsLabel = new System.Windows.Forms.Label();
            this.RecipeDetailDGV = new System.Windows.Forms.DataGridView();
            this.RecipeIngredientsLabel = new System.Windows.Forms.Label();
            this.uiRecipeDetailFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDetailDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiRecipeDetailFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipeNameLabel
            // 
            this.RecipeNameLabel.AutoSize = true;
            this.RecipeNameLabel.Location = new System.Drawing.Point(105, 57);
            this.RecipeNameLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.RecipeNameLabel.Name = "RecipeNameLabel";
            this.RecipeNameLabel.Size = new System.Drawing.Size(209, 37);
            this.RecipeNameLabel.TabIndex = 0;
            this.RecipeNameLabel.Text = "Recipe Name";
            // 
            // RecipeDirectionTextBox
            // 
            this.RecipeDirectionTextBox.Location = new System.Drawing.Point(114, 1019);
            this.RecipeDirectionTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.RecipeDirectionTextBox.Multiline = true;
            this.RecipeDirectionTextBox.Name = "RecipeDirectionTextBox";
            this.RecipeDirectionTextBox.ReadOnly = true;
            this.RecipeDirectionTextBox.Size = new System.Drawing.Size(1638, 220);
            this.RecipeDirectionTextBox.TabIndex = 1;
            // 
            // RecipeDirectionsLabel
            // 
            this.RecipeDirectionsLabel.AutoSize = true;
            this.RecipeDirectionsLabel.Location = new System.Drawing.Point(105, 962);
            this.RecipeDirectionsLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.RecipeDirectionsLabel.Name = "RecipeDirectionsLabel";
            this.RecipeDirectionsLabel.Size = new System.Drawing.Size(168, 37);
            this.RecipeDirectionsLabel.TabIndex = 2;
            this.RecipeDirectionsLabel.Text = "Directions:";
            // 
            // RecipeDetailDGV
            // 
            this.RecipeDetailDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeDetailDGV.Location = new System.Drawing.Point(114, 242);
            this.RecipeDetailDGV.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.RecipeDetailDGV.Name = "RecipeDetailDGV";
            this.RecipeDetailDGV.Size = new System.Drawing.Size(1647, 638);
            this.RecipeDetailDGV.TabIndex = 3;
            // 
            // RecipeIngredientsLabel
            // 
            this.RecipeIngredientsLabel.AutoSize = true;
            this.RecipeIngredientsLabel.Location = new System.Drawing.Point(105, 162);
            this.RecipeIngredientsLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.RecipeIngredientsLabel.Name = "RecipeIngredientsLabel";
            this.RecipeIngredientsLabel.Size = new System.Drawing.Size(192, 37);
            this.RecipeIngredientsLabel.TabIndex = 4;
            this.RecipeIngredientsLabel.Text = "Ingredients: ";
            // 
            // uiRecipeDetailFormBindingSource
            // 
            this.uiRecipeDetailFormBindingSource.DataMember = "IngredientBindingList";
            this.uiRecipeDetailFormBindingSource.DataSource = typeof(CIS560_RecipeManager.RecipeManager.Recipe);
            // 
            // uiRecipeDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1913, 1281);
            this.Controls.Add(this.RecipeIngredientsLabel);
            this.Controls.Add(this.RecipeDetailDGV);
            this.Controls.Add(this.RecipeDirectionsLabel);
            this.Controls.Add(this.RecipeDirectionTextBox);
            this.Controls.Add(this.RecipeNameLabel);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "uiRecipeDetailForm";
            this.Text = "uiRecipeDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDetailDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiRecipeDetailFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecipeNameLabel;
        private System.Windows.Forms.TextBox RecipeDirectionTextBox;
        private System.Windows.Forms.Label RecipeDirectionsLabel;
        private System.Windows.Forms.DataGridView RecipeDetailDGV;
        private System.Windows.Forms.Label RecipeIngredientsLabel;
        private System.Windows.Forms.BindingSource uiRecipeDetailFormBindingSource;
    }
}