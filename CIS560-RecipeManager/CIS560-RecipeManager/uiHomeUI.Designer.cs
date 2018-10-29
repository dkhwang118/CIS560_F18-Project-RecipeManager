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
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDatabaseDefaultDataSet1 = new CIS560_RecipeManager.RecipeDatabaseDefaultDataSet();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.col1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
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
            this.col1DataGridViewTextBoxColumn,
            this.col2DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dataTable1BindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(517, 423);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(835, 516);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.recipeDatabaseDefaultDataSetBindingSource;
            // 
            // recipeDatabaseDefaultDataSet1
            // 
            this.recipeDatabaseDefaultDataSet1.DataSetName = "RecipeDatabaseDefaultDataSet";
            this.recipeDatabaseDefaultDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.recipeDatabaseDefaultDataSet1;
            // 
            // col1DataGridViewTextBoxColumn
            // 
            this.col1DataGridViewTextBoxColumn.DataPropertyName = "Col1";
            this.col1DataGridViewTextBoxColumn.HeaderText = "Col1";
            this.col1DataGridViewTextBoxColumn.Name = "col1DataGridViewTextBoxColumn";
            // 
            // col2DataGridViewTextBoxColumn
            // 
            this.col2DataGridViewTextBoxColumn.DataPropertyName = "Col2";
            this.col2DataGridViewTextBoxColumn.HeaderText = "Col2";
            this.col2DataGridViewTextBoxColumn.Name = "col2DataGridViewTextBoxColumn";
            // 
            // uiHomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1855, 1123);
            this.Controls.Add(this.dataGridView2);
            this.Name = "uiHomeUI";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDatabaseDefaultDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource recipeDatabaseDefaultDataSetBindingSource;
        private RecipeDatabaseDefaultDataSet recipeDatabaseDefaultDataSet;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private RecipeDatabaseDefaultDataSet recipeDatabaseDefaultDataSet1;
    }
}