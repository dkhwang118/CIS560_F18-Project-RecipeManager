namespace CIS560_RecipeManager
{
    partial class uiRecipe
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
            this.RecipeDataGridView = new System.Windows.Forms.DataGridView();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxButton_AddRecipe = new System.Windows.Forms.Button();
            this.recipeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGridView)).BeginInit();
            this.recipeContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipeDataGridView
            // 
            this.RecipeDataGridView.AllowUserToAddRows = false;
            this.RecipeDataGridView.AutoGenerateColumns = false;
            this.RecipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.CategoryName});
            this.RecipeDataGridView.DataSource = this.RecipeBindingSource;
            this.RecipeDataGridView.Location = new System.Drawing.Point(18, 19);
            this.RecipeDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.RecipeDataGridView.MultiSelect = false;
            this.RecipeDataGridView.Name = "RecipeDataGridView";
            this.RecipeDataGridView.ReadOnly = true;
            this.RecipeDataGridView.RowTemplate.Height = 33;
            this.RecipeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecipeDataGridView.Size = new System.Drawing.Size(361, 173);
            this.RecipeDataGridView.TabIndex = 1;
            this.RecipeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipeDataGridView_CellDoubleClick);
            this.RecipeDataGridView.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.RecipeDataGridView_RowContextMenuStripNeeded);
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 134;
            // 
            // uxButton_AddRecipe
            // 
            this.uxButton_AddRecipe.Location = new System.Drawing.Point(278, 202);
            this.uxButton_AddRecipe.Name = "uxButton_AddRecipe";
            this.uxButton_AddRecipe.Size = new System.Drawing.Size(98, 34);
            this.uxButton_AddRecipe.TabIndex = 2;
            this.uxButton_AddRecipe.Text = "Add Recipe";
            this.uxButton_AddRecipe.UseVisualStyleBackColor = true;
            this.uxButton_AddRecipe.Click += new System.EventHandler(this.uxButton_AddRecipe_Click);
            // 
            // recipeContextMenuStrip
            // 
            this.recipeContextMenuStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.recipeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.recipeContextMenuStrip.Name = "recipeContextMenuStrip";
            this.recipeContextMenuStrip.Size = new System.Drawing.Size(421, 122);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(420, 52);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RecipeBindingSource
            // 
            this.RecipeBindingSource.DataMember = "RecipeCollection";
            this.RecipeBindingSource.DataSource = typeof(CIS560_RecipeManager.RecipeManager.RecipeInventory);
            // 
            // uiRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 243);
            this.Controls.Add(this.uxButton_AddRecipe);
            this.Controls.Add(this.RecipeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "uiRecipe";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGridView)).EndInit();
            this.recipeContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView RecipeDataGridView;
        private System.Windows.Forms.Button uxButton_AddRecipe;
        private System.Windows.Forms.BindingSource RecipeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.ContextMenuStrip recipeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}