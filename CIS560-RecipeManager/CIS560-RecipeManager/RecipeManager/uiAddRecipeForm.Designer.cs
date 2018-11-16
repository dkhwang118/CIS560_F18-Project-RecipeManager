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
            this.ingredientListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDatabaseDataSet = new CIS560_RecipeManager.RecipeDatabaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.ingredientsInRecipeDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.ingredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pantryItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnitMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsInRecipeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTextBox_RecipeName
            // 
            this.uxTextBox_RecipeName.Location = new System.Drawing.Point(399, 56);
            this.uxTextBox_RecipeName.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.uxTextBox_RecipeName.Name = "uxTextBox_RecipeName";
            this.uxTextBox_RecipeName.Size = new System.Drawing.Size(1192, 44);
            this.uxTextBox_RecipeName.TabIndex = 0;
            // 
            // uxLabel_RecipeName
            // 
            this.uxLabel_RecipeName.AutoSize = true;
            this.uxLabel_RecipeName.Location = new System.Drawing.Point(116, 59);
            this.uxLabel_RecipeName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.uxLabel_RecipeName.Name = "uxLabel_RecipeName";
            this.uxLabel_RecipeName.Size = new System.Drawing.Size(218, 37);
            this.uxLabel_RecipeName.TabIndex = 1;
            this.uxLabel_RecipeName.Text = "Recipe Name:";
            // 
            // uxButton_AddRecipe
            // 
            this.uxButton_AddRecipe.Location = new System.Drawing.Point(1458, 1114);
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
            this.uxLabel_RecipeDescription.Location = new System.Drawing.Point(69, 870);
            this.uxLabel_RecipeDescription.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.uxLabel_RecipeDescription.Name = "uxLabel_RecipeDescription";
            this.uxLabel_RecipeDescription.Size = new System.Drawing.Size(292, 37);
            this.uxLabel_RecipeDescription.TabIndex = 3;
            this.uxLabel_RecipeDescription.Text = "Recipe Description:";
            // 
            // uxTextBox_RecipeDescription
            // 
            this.uxTextBox_RecipeDescription.Location = new System.Drawing.Point(399, 867);
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
            this.pantryItemNameDataGridViewTextBoxColumn,
            this.ItemUnitMeasurement});
            this.totalIngredientsDGV.DataSource = this.ingredientListBindingSource;
            this.totalIngredientsDGV.Location = new System.Drawing.Point(103, 209);
            this.totalIngredientsDGV.Name = "totalIngredientsDGV";
            this.totalIngredientsDGV.ReadOnly = true;
            this.totalIngredientsDGV.RowTemplate.Height = 46;
            this.totalIngredientsDGV.Size = new System.Drawing.Size(694, 442);
            this.totalIngredientsDGV.TabIndex = 5;
            this.totalIngredientsDGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.totalIngredientsDGV_CellContentDoubleClick);
            // 
            // ingredientListBindingSource
            // 
            this.ingredientListBindingSource.DataMember = "PantryItem";
            this.ingredientListBindingSource.DataSource = this.recipeDatabaseDataSet;
            // 
            // recipeDatabaseDataSet
            // 
            this.recipeDatabaseDataSet.DataSetName = "RecipeDatabaseDataSet";
            this.recipeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "All Ingredients:";
            // 
            // ingredientsInRecipeDGV
            // 
            this.ingredientsInRecipeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsInRecipeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientName,
            this.Unit,
            this.Quantity});
            this.ingredientsInRecipeDGV.Location = new System.Drawing.Point(927, 212);
            this.ingredientsInRecipeDGV.Name = "ingredientsInRecipeDGV";
            this.ingredientsInRecipeDGV.RowTemplate.Height = 46;
            this.ingredientsInRecipeDGV.Size = new System.Drawing.Size(694, 442);
            this.ingredientsInRecipeDGV.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1110, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingredients in Recipe:";
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Location = new System.Drawing.Point(526, 699);
            this.addIngredientButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(694, 77);
            this.addIngredientButton.TabIndex = 9;
            this.addIngredientButton.Text = "Add New Ingredient";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // ingredientName
            // 
            this.ingredientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingredientName.HeaderText = "Ingredient";
            this.ingredientName.Name = "ingredientName";
            this.ingredientName.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 199;
            // 
            // pantryItemNameDataGridViewTextBoxColumn
            // 
            this.pantryItemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pantryItemNameDataGridViewTextBoxColumn.DataPropertyName = "PantryItemName";
            this.pantryItemNameDataGridViewTextBoxColumn.HeaderText = "Ingredient";
            this.pantryItemNameDataGridViewTextBoxColumn.Name = "pantryItemNameDataGridViewTextBoxColumn";
            this.pantryItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ItemUnitMeasurement
            // 
            this.ItemUnitMeasurement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemUnitMeasurement.DataPropertyName = "ItemUnitMeasurement";
            this.ItemUnitMeasurement.HeaderText = "Unit";
            this.ItemUnitMeasurement.Name = "ItemUnitMeasurement";
            this.ItemUnitMeasurement.ReadOnly = true;
            // 
            // uiAddRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 1238);
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
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "uiAddRecipeForm";
            this.Text = "AddNewRecipe_BASIC";
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsInRecipeDGV)).EndInit();
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
        private System.Windows.Forms.BindingSource ingredientListBindingSource;
        private RecipeDatabaseDataSet recipeDatabaseDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn pantryItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnitMeasurement;
    }
}