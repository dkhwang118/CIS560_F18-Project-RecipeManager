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
            this.recipeIngredientsDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.recipeIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTextBox_RecipeName
            // 
            this.uxTextBox_RecipeName.Location = new System.Drawing.Point(399, 57);
            this.uxTextBox_RecipeName.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.uxTextBox_RecipeName.Name = "uxTextBox_RecipeName";
            this.uxTextBox_RecipeName.Size = new System.Drawing.Size(1192, 44);
            this.uxTextBox_RecipeName.TabIndex = 0;
            // 
            // uxLabel_RecipeName
            // 
            this.uxLabel_RecipeName.AutoSize = true;
            this.uxLabel_RecipeName.Location = new System.Drawing.Point(117, 60);
            this.uxLabel_RecipeName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.uxLabel_RecipeName.Name = "uxLabel_RecipeName";
            this.uxLabel_RecipeName.Size = new System.Drawing.Size(218, 37);
            this.uxLabel_RecipeName.TabIndex = 1;
            this.uxLabel_RecipeName.Text = "Recipe Name:";
            // 
            // uxButton_AddRecipe
            // 
            this.uxButton_AddRecipe.Location = new System.Drawing.Point(1457, 1113);
            this.uxButton_AddRecipe.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.uxButton_AddRecipe.Name = "uxButton_AddRecipe";
            this.uxButton_AddRecipe.Size = new System.Drawing.Size(298, 80);
            this.uxButton_AddRecipe.TabIndex = 2;
            this.uxButton_AddRecipe.Text = "Add Recipe";
            this.uxButton_AddRecipe.UseVisualStyleBackColor = true;
            this.uxButton_AddRecipe.Click += new System.EventHandler(this.uxButton_AddRecipe_Click);
            // 
            // uxLabel_RecipeDescription
            // 
            this.uxLabel_RecipeDescription.AutoSize = true;
            this.uxLabel_RecipeDescription.Location = new System.Drawing.Point(70, 871);
            this.uxLabel_RecipeDescription.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.uxLabel_RecipeDescription.Name = "uxLabel_RecipeDescription";
            this.uxLabel_RecipeDescription.Size = new System.Drawing.Size(292, 37);
            this.uxLabel_RecipeDescription.TabIndex = 3;
            this.uxLabel_RecipeDescription.Text = "Recipe Description:";
            // 
            // uxTextBox_RecipeDescription
            // 
            this.uxTextBox_RecipeDescription.Location = new System.Drawing.Point(399, 868);
            this.uxTextBox_RecipeDescription.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.uxTextBox_RecipeDescription.Multiline = true;
            this.uxTextBox_RecipeDescription.Name = "uxTextBox_RecipeDescription";
            this.uxTextBox_RecipeDescription.Size = new System.Drawing.Size(1192, 209);
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
            this.totalIngredientsDGV.Location = new System.Drawing.Point(105, 208);
            this.totalIngredientsDGV.Name = "totalIngredientsDGV";
            this.totalIngredientsDGV.ReadOnly = true;
            this.totalIngredientsDGV.RowTemplate.Height = 46;
            this.totalIngredientsDGV.Size = new System.Drawing.Size(694, 441);
            this.totalIngredientsDGV.TabIndex = 5;
            this.totalIngredientsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.totalIngredientsDGV_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "All Ingredients:";
            // 
            // recipeIngredientsDGV
            // 
            this.recipeIngredientsDGV.AllowUserToAddRows = false;
            this.recipeIngredientsDGV.AutoGenerateColumns = false;
            this.recipeIngredientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeIngredientsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.unitDataGridViewTextBoxColumn1,
            this.Quantity});
            this.recipeIngredientsDGV.DataSource = this.recipeIngredientsBindingSource;
            this.recipeIngredientsDGV.Location = new System.Drawing.Point(928, 211);
            this.recipeIngredientsDGV.Name = "recipeIngredientsDGV";
            this.recipeIngredientsDGV.RowTemplate.Height = 46;
            this.recipeIngredientsDGV.Size = new System.Drawing.Size(694, 441);
            this.recipeIngredientsDGV.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1112, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingredients in Recipe:";
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Location = new System.Drawing.Point(526, 700);
            this.addIngredientButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(694, 77);
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
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // uiAddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 1238);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recipeIngredientsDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalIngredientsDGV);
            this.Controls.Add(this.uxTextBox_RecipeDescription);
            this.Controls.Add(this.uxLabel_RecipeDescription);
            this.Controls.Add(this.uxButton_AddRecipe);
            this.Controls.Add(this.uxLabel_RecipeName);
            this.Controls.Add(this.uxTextBox_RecipeName);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "uiAddRecipeForm";
            this.Text = "AddNewRecipe_BASIC";
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientsDGV)).EndInit();
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
        private System.Windows.Forms.DataGridView recipeIngredientsDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.BindingSource totalIngredientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recipeIngredientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}