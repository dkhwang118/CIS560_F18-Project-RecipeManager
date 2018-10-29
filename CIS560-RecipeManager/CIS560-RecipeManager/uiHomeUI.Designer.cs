namespace CIS560_RecipeManager
{
    partial class uiHomeUI
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
            this.recipeDatabaseDefaultDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDatabaseDefaultDataSet = new CIS560_RecipeManager.RecipeDatabaseDefaultDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDatabaseDataSet_DEMO = new CIS560_RecipeManager.RecipeDatabaseDataSet_DEMO();
            this.recipesDEMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDatabaseDefaultDataSet1 = new CIS560_RecipeManager.RecipeDatabaseDefaultDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uxButton_AddRecipe = new System.Windows.Forms.Button();
            this.recipeDatabaseDataSetDEMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipesTableAdapter = new CIS560_RecipeManager.RecipeDatabaseDataSet_DEMOTableAdapters.RecipesTableAdapter();
            this.recipeDatabaseDataSetDEMOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.recipesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.recipeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet_DEMO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDEMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSetDEMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSetDEMOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // recipeDatabaseDefaultDataSetBindingSource
            // 
            this.recipeDatabaseDefaultDataSetBindingSource.DataSource = this.recipeDatabaseDefaultDataSet;
            this.recipeDatabaseDefaultDataSetBindingSource.Position = 0;
            // 
            // recipeDatabaseDefaultDataSet
            // 
            this.recipeDatabaseDefaultDataSet.DataSetName = "RecipeDatabaseDefaultDataSet";
            this.recipeDatabaseDefaultDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipeIDDataGridViewTextBoxColumn,
            this.recipeNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.recipesBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(97, 207);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(668, 268);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.recipeDatabaseDataSet_DEMO;
            // 
            // recipeDatabaseDataSet_DEMO
            // 
            this.recipeDatabaseDataSet_DEMO.DataSetName = "RecipeDatabaseDataSet_DEMO";
            this.recipeDatabaseDataSet_DEMO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recipesDEMOBindingSource
            // 
            this.recipesDEMOBindingSource.DataMember = "Recipes_DEMO";
            this.recipesDEMOBindingSource.DataSource = this.recipeDatabaseDefaultDataSet;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.recipeDatabaseDefaultDataSet1;
            // 
            // recipeDatabaseDefaultDataSet1
            // 
            this.recipeDatabaseDefaultDataSet1.DataSetName = "RecipeDatabaseDefaultDataSet";
            this.recipeDatabaseDefaultDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.recipeDatabaseDefaultDataSetBindingSource;
            // 
            // uxButton_AddRecipe
            // 
            this.uxButton_AddRecipe.Location = new System.Drawing.Point(652, 501);
            this.uxButton_AddRecipe.Name = "uxButton_AddRecipe";
            this.uxButton_AddRecipe.Size = new System.Drawing.Size(113, 37);
            this.uxButton_AddRecipe.TabIndex = 2;
            this.uxButton_AddRecipe.Text = "Add Recipe";
            this.uxButton_AddRecipe.UseVisualStyleBackColor = true;
            this.uxButton_AddRecipe.Click += new System.EventHandler(this.uxButton_AddRecipe_Click);
            // 
            // recipeDatabaseDataSetDEMOBindingSource
            // 
            this.recipeDatabaseDataSetDEMOBindingSource.DataSource = this.recipeDatabaseDataSet_DEMO;
            this.recipeDatabaseDataSetDEMOBindingSource.Position = 0;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // recipeDatabaseDataSetDEMOBindingSource1
            // 
            this.recipeDatabaseDataSetDEMOBindingSource1.DataSource = this.recipeDatabaseDataSet_DEMO;
            this.recipeDatabaseDataSetDEMOBindingSource1.Position = 0;
            // 
            // recipesBindingSource1
            // 
            this.recipesBindingSource1.DataMember = "Recipes";
            this.recipesBindingSource1.DataSource = this.recipeDatabaseDataSet_DEMO;
            // 
            // recipeIDDataGridViewTextBoxColumn
            // 
            this.recipeIDDataGridViewTextBoxColumn.DataPropertyName = "RecipeID";
            this.recipeIDDataGridViewTextBoxColumn.HeaderText = "RecipeID";
            this.recipeIDDataGridViewTextBoxColumn.Name = "recipeIDDataGridViewTextBoxColumn";
            // 
            // recipeNameDataGridViewTextBoxColumn
            // 
            this.recipeNameDataGridViewTextBoxColumn.DataPropertyName = "RecipeName";
            this.recipeNameDataGridViewTextBoxColumn.HeaderText = "RecipeName";
            this.recipeNameDataGridViewTextBoxColumn.Name = "recipeNameDataGridViewTextBoxColumn";
            // 
            // uiHomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.uxButton_AddRecipe);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uiHomeUI";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.uiHomeUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSet_DEMO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDEMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSetDEMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDataSetDEMOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource recipeDatabaseDefaultDataSetBindingSource;
        private RecipeDatabaseDefaultDataSet recipeDatabaseDefaultDataSet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private RecipeDatabaseDefaultDataSet recipeDatabaseDefaultDataSet1;
        private System.Windows.Forms.BindingSource recipesDEMOBindingSource;
        private System.Windows.Forms.Button uxButton_AddRecipe;
        private System.Windows.Forms.BindingSource recipeDatabaseDataSetDEMOBindingSource;
        private RecipeDatabaseDataSet_DEMO recipeDatabaseDataSet_DEMO;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private RecipeDatabaseDataSet_DEMOTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recipesBindingSource1;
        private System.Windows.Forms.BindingSource recipeDatabaseDataSetDEMOBindingSource1;
    }
}