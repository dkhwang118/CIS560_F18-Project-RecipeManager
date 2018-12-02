namespace CIS560_RecipeManager.ShoppingListManager
{
    partial class uiShowShoppingList
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
            this.uxDataGridView_ShowShoppingList = new System.Windows.Forms.DataGridView();
            this.uxDataGridView_IngredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxDataGridView_IngredientQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingListItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDatabaseDataSet = new CIS560_RecipeManager.RecipeDatabaseDataSet();
            this.shoppingListItemTableAdapter = new CIS560_RecipeManager.RecipeDatabaseDataSetTableAdapters.ShoppingListItemTableAdapter();
            this.shoppingListItemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingListTableAdapter = new CIS560_RecipeManager.RecipeDatabaseDataSetTableAdapters.ShoppingListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridView_ShowShoppingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListItemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGridView_ShowShoppingList
            // 
            this.uxDataGridView_ShowShoppingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGridView_ShowShoppingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uxDataGridView_IngredientName,
            this.uxDataGridView_IngredientQuantity});
            this.uxDataGridView_ShowShoppingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxDataGridView_ShowShoppingList.Location = new System.Drawing.Point(0, 0);
            this.uxDataGridView_ShowShoppingList.Name = "uxDataGridView_ShowShoppingList";
            this.uxDataGridView_ShowShoppingList.ReadOnly = true;
            this.uxDataGridView_ShowShoppingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxDataGridView_ShowShoppingList.Size = new System.Drawing.Size(470, 346);
            this.uxDataGridView_ShowShoppingList.TabIndex = 0;
            // 
            // uxDataGridView_IngredientName
            // 
            this.uxDataGridView_IngredientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uxDataGridView_IngredientName.HeaderText = "Ingredient";
            this.uxDataGridView_IngredientName.Name = "uxDataGridView_IngredientName";
            this.uxDataGridView_IngredientName.ReadOnly = true;
            // 
            // uxDataGridView_IngredientQuantity
            // 
            this.uxDataGridView_IngredientQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uxDataGridView_IngredientQuantity.HeaderText = "Quantity";
            this.uxDataGridView_IngredientQuantity.Name = "uxDataGridView_IngredientQuantity";
            this.uxDataGridView_IngredientQuantity.ReadOnly = true;
            // 
            // shoppingListItemBindingSource
            // 
            this.shoppingListItemBindingSource.DataMember = "ShoppingListItem";
            this.shoppingListItemBindingSource.DataSource = this.recipeDatabaseDataSet;
            // 
            // recipeDatabaseDataSet
            // 
            this.recipeDatabaseDataSet.DataSetName = "RecipeDatabaseDataSet";
            this.recipeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoppingListItemTableAdapter
            // 
            this.shoppingListItemTableAdapter.ClearBeforeFill = true;
            // 
            // shoppingListItemBindingSource1
            // 
            this.shoppingListItemBindingSource1.DataMember = "ShoppingListItem";
            this.shoppingListItemBindingSource1.DataSource = this.recipeDatabaseDataSet;
            // 
            // shoppingListBindingSource
            // 
            this.shoppingListBindingSource.DataMember = "ShoppingList";
            this.shoppingListBindingSource.DataSource = this.recipeDatabaseDataSet;
            // 
            // shoppingListTableAdapter
            // 
            this.shoppingListTableAdapter.ClearBeforeFill = true;
            // 
            // uiShowShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 346);
            this.Controls.Add(this.uxDataGridView_ShowShoppingList);
            this.Name = "uiShowShoppingList";
            this.Text = "Current Shopping List";
            this.Load += new System.EventHandler(this.uiShowShoppingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGridView_ShowShoppingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListItemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGridView_ShowShoppingList;
        private RecipeDatabaseDataSet recipeDatabaseDataSet;
        private System.Windows.Forms.BindingSource shoppingListItemBindingSource;
        private RecipeDatabaseDataSetTableAdapters.ShoppingListItemTableAdapter shoppingListItemTableAdapter;
        private System.Windows.Forms.BindingSource shoppingListItemBindingSource1;
        private System.Windows.Forms.BindingSource shoppingListBindingSource;
        private RecipeDatabaseDataSetTableAdapters.ShoppingListTableAdapter shoppingListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxDataGridView_IngredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxDataGridView_IngredientQuantity;
    }
}