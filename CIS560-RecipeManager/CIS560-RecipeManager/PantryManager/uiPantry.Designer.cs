namespace CIS560_RecipeManager
{
    partial class uiPantry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.recipeDatabaseDataSet_DEMO = new CIS560_RecipeManager.RecipeDatabaseDataSet_DEMO();
            this.recipeDatabaseDataSetDEMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uxPantryItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.pantryItemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemUnitMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInPantryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pantryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDatabaseDataSet = new CIS560_RecipeManager.RecipeDatabaseDataSet();
            this.pantryItemTableAdapter = new CIS560_RecipeManager.RecipeDatabaseDataSetTableAdapters.PantryItemTableAdapter();
            this.uxButton_AddIngredient = new System.Windows.Forms.Button();
            this.uxButton_DeleteIngredient = new System.Windows.Forms.Button();
            this.uxButton_UpdateIngredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet_DEMO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSetDEMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPantryItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantryItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeDatabaseDataSet_DEMO
            // 
            this.recipeDatabaseDataSet_DEMO.DataSetName = "RecipeDatabaseDataSet_DEMO";
            this.recipeDatabaseDataSet_DEMO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipeDatabaseDataSetDEMOBindingSource
            // 
            this.recipeDatabaseDataSetDEMOBindingSource.DataSource = this.recipeDatabaseDataSet_DEMO;
            this.recipeDatabaseDataSetDEMOBindingSource.Position = 0;
            // 
            // uxPantryItemsDataGridView
            // 
            this.uxPantryItemsDataGridView.AllowUserToAddRows = false;
            this.uxPantryItemsDataGridView.AllowUserToDeleteRows = false;
            this.uxPantryItemsDataGridView.AllowUserToResizeColumns = false;
            this.uxPantryItemsDataGridView.AllowUserToResizeRows = false;
            this.uxPantryItemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxPantryItemsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxPantryItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uxPantryItemsDataGridView.ColumnHeadersHeight = 40;
            this.uxPantryItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uxPantryItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pantryItemNameDataGridViewTextBoxColumn,
            this.itemUnitMeasurementDataGridViewTextBoxColumn,
            this.quantityInPantryDataGridViewTextBoxColumn});
            this.uxPantryItemsDataGridView.DataSource = this.pantryItemBindingSource;
            this.uxPantryItemsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.uxPantryItemsDataGridView.MultiSelect = false;
            this.uxPantryItemsDataGridView.Name = "uxPantryItemsDataGridView";
            this.uxPantryItemsDataGridView.ReadOnly = true;
            this.uxPantryItemsDataGridView.RowHeadersVisible = false;
            this.uxPantryItemsDataGridView.RowHeadersWidth = 120;
            this.uxPantryItemsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.uxPantryItemsDataGridView.Size = new System.Drawing.Size(529, 317);
            this.uxPantryItemsDataGridView.TabIndex = 0;
            // 
            // pantryItemNameDataGridViewTextBoxColumn
            // 
            this.pantryItemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pantryItemNameDataGridViewTextBoxColumn.DataPropertyName = "PantryItemName";
            this.pantryItemNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pantryItemNameDataGridViewTextBoxColumn.Name = "pantryItemNameDataGridViewTextBoxColumn";
            this.pantryItemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pantryItemNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pantryItemNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // itemUnitMeasurementDataGridViewTextBoxColumn
            // 
            this.itemUnitMeasurementDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.itemUnitMeasurementDataGridViewTextBoxColumn.DataPropertyName = "ItemUnitMeasurement";
            this.itemUnitMeasurementDataGridViewTextBoxColumn.HeaderText = "Unit of Measurement for Item";
            this.itemUnitMeasurementDataGridViewTextBoxColumn.Name = "itemUnitMeasurementDataGridViewTextBoxColumn";
            this.itemUnitMeasurementDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemUnitMeasurementDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.itemUnitMeasurementDataGridViewTextBoxColumn.Width = 168;
            // 
            // quantityInPantryDataGridViewTextBoxColumn
            // 
            this.quantityInPantryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantityInPantryDataGridViewTextBoxColumn.DataPropertyName = "QuantityInPantry";
            this.quantityInPantryDataGridViewTextBoxColumn.HeaderText = "Quantity of Item in Pantry";
            this.quantityInPantryDataGridViewTextBoxColumn.Name = "quantityInPantryDataGridViewTextBoxColumn";
            this.quantityInPantryDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityInPantryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quantityInPantryDataGridViewTextBoxColumn.Width = 150;
            // 
            // pantryItemBindingSource
            // 
            this.pantryItemBindingSource.DataMember = "PantryItem";
            this.pantryItemBindingSource.DataSource = this.recipeDatabaseDataSet;
            // 
            // recipeDatabaseDataSet
            // 
            this.recipeDatabaseDataSet.DataSetName = "RecipeDatabaseDataSet";
            this.recipeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pantryItemTableAdapter
            // 
            this.pantryItemTableAdapter.ClearBeforeFill = true;
            // 
            // uxButton_AddIngredient
            // 
            this.uxButton_AddIngredient.Location = new System.Drawing.Point(10, 333);
            this.uxButton_AddIngredient.Margin = new System.Windows.Forms.Padding(1);
            this.uxButton_AddIngredient.Name = "uxButton_AddIngredient";
            this.uxButton_AddIngredient.Size = new System.Drawing.Size(142, 41);
            this.uxButton_AddIngredient.TabIndex = 1;
            this.uxButton_AddIngredient.Text = "Add Ingredient";
            this.uxButton_AddIngredient.UseVisualStyleBackColor = true;
            this.uxButton_AddIngredient.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // uxButton_DeleteIngredient
            // 
            this.uxButton_DeleteIngredient.Location = new System.Drawing.Point(406, 333);
            this.uxButton_DeleteIngredient.Margin = new System.Windows.Forms.Padding(1);
            this.uxButton_DeleteIngredient.Name = "uxButton_DeleteIngredient";
            this.uxButton_DeleteIngredient.Size = new System.Drawing.Size(135, 41);
            this.uxButton_DeleteIngredient.TabIndex = 2;
            this.uxButton_DeleteIngredient.Text = "Delete Ingredient";
            this.uxButton_DeleteIngredient.UseVisualStyleBackColor = true;
            this.uxButton_DeleteIngredient.Click += new System.EventHandler(this.deleteIngredientButton_Click);
            // 
            // uxButton_UpdateIngredient
            // 
            this.uxButton_UpdateIngredient.Location = new System.Drawing.Point(212, 333);
            this.uxButton_UpdateIngredient.Margin = new System.Windows.Forms.Padding(1);
            this.uxButton_UpdateIngredient.Name = "uxButton_UpdateIngredient";
            this.uxButton_UpdateIngredient.Size = new System.Drawing.Size(141, 41);
            this.uxButton_UpdateIngredient.TabIndex = 4;
            this.uxButton_UpdateIngredient.Text = "Update Ingredient";
            this.uxButton_UpdateIngredient.UseVisualStyleBackColor = true;
            this.uxButton_UpdateIngredient.Click += new System.EventHandler(this.updateIngredientButton_Click);
            // 
            // uiPantry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 381);
            this.Controls.Add(this.uxButton_UpdateIngredient);
            this.Controls.Add(this.uxButton_DeleteIngredient);
            this.Controls.Add(this.uxButton_AddIngredient);
            this.Controls.Add(this.uxPantryItemsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "uiPantry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pantry Items";
            this.Load += new System.EventHandler(this.uiPantryItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet_DEMO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSetDEMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPantryItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantryItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RecipeDatabaseDataSet_DEMO recipeDatabaseDataSet_DEMO;
        private System.Windows.Forms.BindingSource recipeDatabaseDataSetDEMOBindingSource;
        private System.Windows.Forms.DataGridView uxPantryItemsDataGridView;
        private RecipeDatabaseDataSet recipeDatabaseDataSet;
        private System.Windows.Forms.BindingSource pantryItemBindingSource;
        private RecipeDatabaseDataSetTableAdapters.PantryItemTableAdapter pantryItemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pantryItemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemUnitMeasurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInPantryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button uxButton_AddIngredient;
        private System.Windows.Forms.Button uxButton_DeleteIngredient;
        private System.Windows.Forms.Button uxButton_UpdateIngredient;
    }
}