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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.recipeDatabaseDataSet_DEMO = new CIS560_RecipeManager.RecipeDatabaseDataSet_DEMO();
            this.recipeDatabaseDataSetDEMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uxPantryItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.recipeDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDatabaseDataSet = new CIS560_RecipeManager.RecipeDatabaseDataSet();
            this.pantryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pantryItemTableAdapter = new CIS560_RecipeManager.RecipeDatabaseDataSetTableAdapters.PantryItemTableAdapter();
            this.recipeDatabase_IngredientTable = new CIS560_RecipeManager.RecipeDatabase_IngredientTable();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientTableAdapter = new CIS560_RecipeManager.RecipeDatabase_IngredientTableTableAdapters.IngredientTableAdapter();
            this.ingredientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInPantryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitMeasurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxButton_AddIngredientDialogue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet_DEMO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSetDEMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPantryItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantryItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabase_IngredientTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxPantryItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uxPantryItemsDataGridView.ColumnHeadersHeight = 40;
            this.uxPantryItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uxPantryItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityInPantryDataGridViewTextBoxColumn,
            this.unitMeasurementDataGridViewTextBoxColumn});
            this.uxPantryItemsDataGridView.DataSource = this.ingredientBindingSource;
            this.uxPantryItemsDataGridView.Location = new System.Drawing.Point(115, 151);
            this.uxPantryItemsDataGridView.MultiSelect = false;
            this.uxPantryItemsDataGridView.Name = "uxPantryItemsDataGridView";
            this.uxPantryItemsDataGridView.ReadOnly = true;
            this.uxPantryItemsDataGridView.RowHeadersVisible = false;
            this.uxPantryItemsDataGridView.RowHeadersWidth = 120;
            this.uxPantryItemsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.uxPantryItemsDataGridView.Size = new System.Drawing.Size(524, 437);
            this.uxPantryItemsDataGridView.TabIndex = 0;
            // 
            // recipeDatabaseDataSetBindingSource
            // 
            this.recipeDatabaseDataSetBindingSource.DataSource = this.recipeDatabaseDataSet;
            this.recipeDatabaseDataSetBindingSource.Position = 0;
            // 
            // recipeDatabaseDataSet
            // 
            this.recipeDatabaseDataSet.DataSetName = "RecipeDatabaseDataSet";
            this.recipeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pantryItemBindingSource
            // 
            this.pantryItemBindingSource.DataMember = "PantryItem";
            this.pantryItemBindingSource.DataSource = this.recipeDatabaseDataSet;
            // 
            // pantryItemTableAdapter
            // 
            this.pantryItemTableAdapter.ClearBeforeFill = true;
            // 
            // recipeDatabase_IngredientTable
            // 
            this.recipeDatabase_IngredientTable.DataSetName = "RecipeDatabase_IngredientTable";
            this.recipeDatabase_IngredientTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataMember = "Ingredient";
            this.ingredientBindingSource.DataSource = this.recipeDatabase_IngredientTable;
            // 
            // ingredientTableAdapter
            // 
            this.ingredientTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientIdDataGridViewTextBoxColumn
            // 
            this.ingredientIdDataGridViewTextBoxColumn.DataPropertyName = "IngredientId";
            this.ingredientIdDataGridViewTextBoxColumn.HeaderText = "IngredientId";
            this.ingredientIdDataGridViewTextBoxColumn.Name = "ingredientIdDataGridViewTextBoxColumn";
            this.ingredientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityInPantryDataGridViewTextBoxColumn
            // 
            this.quantityInPantryDataGridViewTextBoxColumn.DataPropertyName = "QuantityInPantry";
            this.quantityInPantryDataGridViewTextBoxColumn.HeaderText = "QuantityInPantry";
            this.quantityInPantryDataGridViewTextBoxColumn.Name = "quantityInPantryDataGridViewTextBoxColumn";
            this.quantityInPantryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitMeasurementDataGridViewTextBoxColumn
            // 
            this.unitMeasurementDataGridViewTextBoxColumn.DataPropertyName = "UnitMeasurement";
            this.unitMeasurementDataGridViewTextBoxColumn.HeaderText = "UnitMeasurement";
            this.unitMeasurementDataGridViewTextBoxColumn.Name = "unitMeasurementDataGridViewTextBoxColumn";
            this.unitMeasurementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uxButton_AddIngredientDialogue
            // 
            this.uxButton_AddIngredientDialogue.Location = new System.Drawing.Point(490, 604);
            this.uxButton_AddIngredientDialogue.Name = "uxButton_AddIngredientDialogue";
            this.uxButton_AddIngredientDialogue.Size = new System.Drawing.Size(149, 41);
            this.uxButton_AddIngredientDialogue.TabIndex = 1;
            this.uxButton_AddIngredientDialogue.Text = "Add Ingredient";
            this.uxButton_AddIngredientDialogue.UseVisualStyleBackColor = true;
            this.uxButton_AddIngredientDialogue.Click += new System.EventHandler(this.uxButton_AddIngredient_Click);
            // 
            // uiPantry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 767);
            this.Controls.Add(this.uxButton_AddIngredientDialogue);
            this.Controls.Add(this.uxPantryItemsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "uiPantry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pantry Items";
            this.Load += new System.EventHandler(this.uiPantryItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet_DEMO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSetDEMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPantryItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantryItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabase_IngredientTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RecipeDatabaseDataSet_DEMO recipeDatabaseDataSet_DEMO;
        private System.Windows.Forms.BindingSource recipeDatabaseDataSetDEMOBindingSource;
        private System.Windows.Forms.DataGridView uxPantryItemsDataGridView;
        private RecipeDatabaseDataSet recipeDatabaseDataSet;
        private System.Windows.Forms.BindingSource pantryItemBindingSource;
        private RecipeDatabaseDataSetTableAdapters.PantryItemTableAdapter pantryItemTableAdapter;
        private System.Windows.Forms.BindingSource recipeDatabaseDataSetBindingSource;
        private RecipeDatabase_IngredientTable recipeDatabase_IngredientTable;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private RecipeDatabase_IngredientTableTableAdapters.IngredientTableAdapter ingredientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInPantryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitMeasurementDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button uxButton_AddIngredientDialogue;
    }
}