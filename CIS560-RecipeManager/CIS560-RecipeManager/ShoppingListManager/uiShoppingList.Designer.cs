namespace CIS560_RecipeManager.ShoppingListManager
{
    partial class uiShoppingList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recipeDatabaseDataSet = new CIS560_RecipeManager.RecipeDatabaseDataSet();
            this.shoppingListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoppingListTableAdapter = new CIS560_RecipeManager.RecipeDatabaseDataSetTableAdapters.ShoppingListTableAdapter();
            this.shoppingListIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoppingListNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxButton_AddShoppingList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shoppingListIDDataGridViewTextBoxColumn,
            this.shoppingListNameDataGridViewTextBoxColumn,
            this.createdOnDataGridViewTextBoxColumn,
            this.updatedOnDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shoppingListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // recipeDatabaseDataSet
            // 
            this.recipeDatabaseDataSet.DataSetName = "RecipeDatabaseDataSet";
            this.recipeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // shoppingListIDDataGridViewTextBoxColumn
            // 
            this.shoppingListIDDataGridViewTextBoxColumn.DataPropertyName = "ShoppingListID";
            this.shoppingListIDDataGridViewTextBoxColumn.HeaderText = "ShoppingListID";
            this.shoppingListIDDataGridViewTextBoxColumn.Name = "shoppingListIDDataGridViewTextBoxColumn";
            // 
            // shoppingListNameDataGridViewTextBoxColumn
            // 
            this.shoppingListNameDataGridViewTextBoxColumn.DataPropertyName = "ShoppingListName";
            this.shoppingListNameDataGridViewTextBoxColumn.HeaderText = "ShoppingListName";
            this.shoppingListNameDataGridViewTextBoxColumn.Name = "shoppingListNameDataGridViewTextBoxColumn";
            // 
            // createdOnDataGridViewTextBoxColumn
            // 
            this.createdOnDataGridViewTextBoxColumn.DataPropertyName = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.HeaderText = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.Name = "createdOnDataGridViewTextBoxColumn";
            // 
            // updatedOnDataGridViewTextBoxColumn
            // 
            this.updatedOnDataGridViewTextBoxColumn.DataPropertyName = "UpdatedOn";
            this.updatedOnDataGridViewTextBoxColumn.HeaderText = "UpdatedOn";
            this.updatedOnDataGridViewTextBoxColumn.Name = "updatedOnDataGridViewTextBoxColumn";
            // 
            // uxButton_AddShoppingList
            // 
            this.uxButton_AddShoppingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxButton_AddShoppingList.Location = new System.Drawing.Point(144, 175);
            this.uxButton_AddShoppingList.Name = "uxButton_AddShoppingList";
            this.uxButton_AddShoppingList.Size = new System.Drawing.Size(150, 36);
            this.uxButton_AddShoppingList.TabIndex = 1;
            this.uxButton_AddShoppingList.Text = "Add Shopping List";
            this.uxButton_AddShoppingList.UseVisualStyleBackColor = true;
            this.uxButton_AddShoppingList.Click += new System.EventHandler(this.uxButton_AddShoppingList_Click);
            // 
            // uiShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 231);
            this.Controls.Add(this.uxButton_AddShoppingList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "uiShoppingList";
            this.Text = "Shopping List Home";
            this.Load += new System.EventHandler(this.uiShoppingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RecipeDatabaseDataSet recipeDatabaseDataSet;
        private System.Windows.Forms.BindingSource shoppingListBindingSource;
        private RecipeDatabaseDataSetTableAdapters.ShoppingListTableAdapter shoppingListTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoppingListIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoppingListNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button uxButton_AddShoppingList;
    }
}