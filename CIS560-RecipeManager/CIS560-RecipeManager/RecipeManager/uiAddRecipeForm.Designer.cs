namespace CIS560_RecipeManager
{
    partial class uiAddRecipeForm
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
            this.uxTextBox_RecipeName = new System.Windows.Forms.TextBox();
            this.uxLabel_RecipeName = new System.Windows.Forms.Label();
            this.uxButton_AddRecipe = new System.Windows.Forms.Button();
            this.uxLabel_RecipeDescription = new System.Windows.Forms.Label();
            this.uxTextBox_RecipeDescription = new System.Windows.Forms.TextBox();
            this.totalIngredientsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ingredientsInRecipeDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.recipeIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsInRecipeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTextBox_RecipeName
            // 
            this.uxTextBox_RecipeName.Location = new System.Drawing.Point(126, 20);
            this.uxTextBox_RecipeName.Name = "uxTextBox_RecipeName";
            this.uxTextBox_RecipeName.Size = new System.Drawing.Size(379, 20);
            this.uxTextBox_RecipeName.TabIndex = 0;
            // 
            // uxLabel_RecipeName
            // 
            this.uxLabel_RecipeName.AutoSize = true;
            this.uxLabel_RecipeName.Location = new System.Drawing.Point(37, 21);
            this.uxLabel_RecipeName.Name = "uxLabel_RecipeName";
            this.uxLabel_RecipeName.Size = new System.Drawing.Size(75, 13);
            this.uxLabel_RecipeName.TabIndex = 1;
            this.uxLabel_RecipeName.Text = "Recipe Name:";
            // 
            // uxButton_AddRecipe
            // 
            this.uxButton_AddRecipe.Location = new System.Drawing.Point(460, 391);
            this.uxButton_AddRecipe.Name = "uxButton_AddRecipe";
            this.uxButton_AddRecipe.Size = new System.Drawing.Size(94, 28);
            this.uxButton_AddRecipe.TabIndex = 2;
            this.uxButton_AddRecipe.Text = "Add Recipe";
            this.uxButton_AddRecipe.UseVisualStyleBackColor = true;
            this.uxButton_AddRecipe.Click += new System.EventHandler(this.uxButton_AddRecipe_Click);
            // 
            // uxLabel_RecipeDescription
            // 
            this.uxLabel_RecipeDescription.AutoSize = true;
            this.uxLabel_RecipeDescription.Location = new System.Drawing.Point(22, 306);
            this.uxLabel_RecipeDescription.Name = "uxLabel_RecipeDescription";
            this.uxLabel_RecipeDescription.Size = new System.Drawing.Size(100, 13);
            this.uxLabel_RecipeDescription.TabIndex = 3;
            this.uxLabel_RecipeDescription.Text = "Recipe Description:";
            // 
            // uxTextBox_RecipeDescription
            // 
            this.uxTextBox_RecipeDescription.Location = new System.Drawing.Point(126, 305);
            this.uxTextBox_RecipeDescription.Multiline = true;
            this.uxTextBox_RecipeDescription.Name = "uxTextBox_RecipeDescription";
            this.uxTextBox_RecipeDescription.Size = new System.Drawing.Size(379, 76);
            this.uxTextBox_RecipeDescription.TabIndex = 4;
            // 
            // totalIngredientsDGV
            // 
            this.totalIngredientsDGV.AutoGenerateColumns = false;
            this.totalIngredientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalIngredientsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.totalIngredientsDGV.DataSource = this.totalIngredientsBindingSource;
            this.totalIngredientsDGV.Location = new System.Drawing.Point(33, 73);
            this.totalIngredientsDGV.Margin = new System.Windows.Forms.Padding(1);
            this.totalIngredientsDGV.Name = "totalIngredientsDGV";
            this.totalIngredientsDGV.ReadOnly = true;
            this.totalIngredientsDGV.RowTemplate.Height = 46;
            this.totalIngredientsDGV.Size = new System.Drawing.Size(219, 155);
            this.totalIngredientsDGV.TabIndex = 5;
            this.totalIngredientsDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.totalIngredientsDGV_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "All Ingredients:";
            // 
            // ingredientsInRecipeDGV
            // 
            this.ingredientsInRecipeDGV.AllowUserToAddRows = false;
            this.ingredientsInRecipeDGV.AutoGenerateColumns = false;
            this.ingredientsInRecipeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsInRecipeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.unitDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn});
            this.ingredientsInRecipeDGV.DataSource = this.recipeIngredientsBindingSource;
            this.ingredientsInRecipeDGV.Location = new System.Drawing.Point(293, 74);
            this.ingredientsInRecipeDGV.Margin = new System.Windows.Forms.Padding(1);
            this.ingredientsInRecipeDGV.Name = "ingredientsInRecipeDGV";
            this.ingredientsInRecipeDGV.RowTemplate.Height = 46;
            this.ingredientsInRecipeDGV.Size = new System.Drawing.Size(219, 155);
            this.ingredientsInRecipeDGV.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingredients in Recipe:";
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Location = new System.Drawing.Point(166, 246);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(219, 27);
            this.addIngredientButton.TabIndex = 9;
            this.addIngredientButton.Text = "Add New Ingredient";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // recipeIngredientsBindingSource
            // 
            this.recipeIngredientsBindingSource.DataMember = "RecipeIngredients";
            this.recipeIngredientsBindingSource.DataSource = typeof(CIS560_RecipeManager.RecipeManager.AddRecipeViewModel);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalIngredientsBindingSource
            // 
            this.totalIngredientsBindingSource.DataMember = "TotalIngredients";
            this.totalIngredientsBindingSource.DataSource = typeof(CIS560_RecipeManager.RecipeManager.AddRecipeViewModel);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn1
            // 
            this.unitDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitDataGridViewTextBoxColumn1.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn1.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn1.Name = "unitDataGridViewTextBoxColumn1";
            this.unitDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uiAddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 435);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingredientsInRecipeDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalIngredientsDGV);
            this.Controls.Add(this.uxTextBox_RecipeDescription);
            this.Controls.Add(this.uxLabel_RecipeDescription);
            this.Controls.Add(this.uxButton_AddRecipe);
            this.Controls.Add(this.uxLabel_RecipeName);
            this.Controls.Add(this.uxTextBox_RecipeName);
            this.Name = "uiAddRecipeForm";
            this.Text = "AddNewRecipe_BASIC";
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsInRecipeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextBox_RecipeName;
        private System.Windows.Forms.Label uxLabel_RecipeName;
        private System.Windows.Forms.Button uxButton_AddRecipe;
        private System.Windows.Forms.Label uxLabel_RecipeDescription;
        private System.Windows.Forms.TextBox uxTextBox_RecipeDescription;
        private System.Windows.Forms.DataGridView totalIngredientsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ingredientsInRecipeDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.BindingSource totalIngredientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recipeIngredientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}