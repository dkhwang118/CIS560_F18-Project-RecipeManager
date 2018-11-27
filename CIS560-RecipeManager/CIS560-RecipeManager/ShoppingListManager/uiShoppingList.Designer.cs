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
            this.shoppingListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDatabaseDataSet = new CIS560_RecipeManager.RecipeDatabaseDataSet();
            this.shoppingListTableAdapter = new CIS560_RecipeManager.RecipeDatabaseDataSetTableAdapters.ShoppingListTableAdapter();
            this.uxButton_AddShoppingList = new System.Windows.Forms.Button();
            this.uxButton_ShowShoppingList = new System.Windows.Forms.Button();
            this.shoppingListNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shoppingListNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shoppingListBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // shoppingListBindingSource
            // 
            this.shoppingListBindingSource.DataMember = "ShoppingList";
            this.shoppingListBindingSource.DataSource = this.recipeDatabaseDataSet;
            // 
            // recipeDatabaseDataSet
            // 
            this.recipeDatabaseDataSet.DataSetName = "RecipeDatabaseDataSet";
            this.recipeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoppingListTableAdapter
            // 
            this.shoppingListTableAdapter.ClearBeforeFill = true;
            // 
            // uxButton_AddShoppingList
            // 
            this.uxButton_AddShoppingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.uxButton_AddShoppingList.Location = new System.Drawing.Point(21, 174);
            this.uxButton_AddShoppingList.Name = "uxButton_AddShoppingList";
            this.uxButton_AddShoppingList.Size = new System.Drawing.Size(150, 36);
            this.uxButton_AddShoppingList.TabIndex = 1;
            this.uxButton_AddShoppingList.Text = "Add Shopping List";
            this.uxButton_AddShoppingList.UseVisualStyleBackColor = true;
            this.uxButton_AddShoppingList.Click += new System.EventHandler(this.uxButton_AddShoppingList_Click);
            // 
            // uxButton_ShowShoppingList
            // 
            this.uxButton_ShowShoppingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton_ShowShoppingList.Location = new System.Drawing.Point(231, 174);
            this.uxButton_ShowShoppingList.Name = "uxButton_ShowShoppingList";
            this.uxButton_ShowShoppingList.Size = new System.Drawing.Size(176, 36);
            this.uxButton_ShowShoppingList.TabIndex = 2;
            this.uxButton_ShowShoppingList.Text = "Show Shopping List";
            this.uxButton_ShowShoppingList.UseVisualStyleBackColor = true;
            this.uxButton_ShowShoppingList.Click += new System.EventHandler(this.uxButton_ShowShoppingList_Click);
            // 
            // shoppingListNameDataGridViewTextBoxColumn
            // 
            this.shoppingListNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shoppingListNameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.shoppingListNameDataGridViewTextBoxColumn.HeaderText = "ShoppingListName";
            this.shoppingListNameDataGridViewTextBoxColumn.Name = "shoppingListNameDataGridViewTextBoxColumn";
            // 
            // uiShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 231);
            this.Controls.Add(this.uxButton_ShowShoppingList);
            this.Controls.Add(this.uxButton_AddShoppingList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "uiShoppingList";
            this.Text = "Shopping List Home";
            this.Load += new System.EventHandler(this.uiShoppingList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RecipeDatabaseDataSet recipeDatabaseDataSet;
        private System.Windows.Forms.BindingSource shoppingListBindingSource;
        private RecipeDatabaseDataSetTableAdapters.ShoppingListTableAdapter shoppingListTableAdapter;
        private System.Windows.Forms.Button uxButton_AddShoppingList;
        private System.Windows.Forms.Button uxButton_ShowShoppingList;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoppingListNameDataGridViewTextBoxColumn;
    }
}