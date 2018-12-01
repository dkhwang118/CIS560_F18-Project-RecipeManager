namespace CIS560_RecipeManager.ShoppingListManager
{
    partial class uiAddShoppingList
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
            this.uxButton_CreateShoppingListFromRecipe = new System.Windows.Forms.Button();
            this.uxTextBox_ShoppingListName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxDataGridView_RecipesForShoppingList = new System.Windows.Forms.DataGridView();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDatabaseDataSet = new CIS560_RecipeManager.RecipeDatabaseDataSet();
            this.recipesTableAdapter = new CIS560_RecipeManager.RecipeDatabaseDataSetTableAdapters.RecipesTableAdapter();
            this.RecipeNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridView_RecipesForShoppingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uxButton_CreateShoppingListFromRecipe
            // 
            this.uxButton_CreateShoppingListFromRecipe.Location = new System.Drawing.Point(157, 259);
            this.uxButton_CreateShoppingListFromRecipe.Name = "uxButton_CreateShoppingListFromRecipe";
            this.uxButton_CreateShoppingListFromRecipe.Size = new System.Drawing.Size(129, 46);
            this.uxButton_CreateShoppingListFromRecipe.TabIndex = 1;
            this.uxButton_CreateShoppingListFromRecipe.Text = "Create Shopping List From Recipe(s)";
            this.uxButton_CreateShoppingListFromRecipe.UseVisualStyleBackColor = true;
            this.uxButton_CreateShoppingListFromRecipe.Click += new System.EventHandler(this.uxButton_CreateShoppingListFromRecipe_Click);
            // 
            // uxTextBox_ShoppingListName
            // 
            this.uxTextBox_ShoppingListName.Location = new System.Drawing.Point(12, 233);
            this.uxTextBox_ShoppingListName.Name = "uxTextBox_ShoppingListName";
            this.uxTextBox_ShoppingListName.Size = new System.Drawing.Size(431, 20);
            this.uxTextBox_ShoppingListName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shopping list name";
            // 
            // uxDataGridView_RecipesForShoppingList
            // 
            this.uxDataGridView_RecipesForShoppingList.AutoGenerateColumns = false;
            this.uxDataGridView_RecipesForShoppingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGridView_RecipesForShoppingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecipeNameColumn,
            this.ID});
            this.uxDataGridView_RecipesForShoppingList.DataSource = this.recipesBindingSource;
            this.uxDataGridView_RecipesForShoppingList.Location = new System.Drawing.Point(-1, -1);
            this.uxDataGridView_RecipesForShoppingList.Name = "uxDataGridView_RecipesForShoppingList";
            this.uxDataGridView_RecipesForShoppingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxDataGridView_RecipesForShoppingList.Size = new System.Drawing.Size(455, 205);
            this.uxDataGridView_RecipesForShoppingList.TabIndex = 5;
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.recipeDatabaseDataSet;
            // 
            // recipeDatabaseDataSet
            // 
            this.recipeDatabaseDataSet.DataSetName = "RecipeDatabaseDataSet";
            this.recipeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // RecipeNameColumn
            // 
            this.RecipeNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RecipeNameColumn.DataPropertyName = "RecipeName";
            this.RecipeNameColumn.HeaderText = "Recipe";
            this.RecipeNameColumn.Name = "RecipeNameColumn";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "RecipeID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // uiAddShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 317);
            this.Controls.Add(this.uxDataGridView_RecipesForShoppingList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxTextBox_ShoppingListName);
            this.Controls.Add(this.uxButton_CreateShoppingListFromRecipe);
            this.Name = "uiAddShoppingList";
            this.Text = "Add a Shopping List";
            this.Load += new System.EventHandler(this.uiAddShoppingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridView_RecipesForShoppingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uxButton_CreateShoppingListFromRecipe;
        private System.Windows.Forms.TextBox uxTextBox_ShoppingListName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uxDataGridView_RecipesForShoppingList;
        private RecipeDatabaseDataSet recipeDatabaseDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private RecipeDatabaseDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecipeNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}