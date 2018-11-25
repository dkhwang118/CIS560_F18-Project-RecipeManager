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
            this.uxButton_AddRecipe = new System.Windows.Forms.Button();
            this.recipeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecipeDataGridView = new System.Windows.Forms.DataGridView();
            this.availableWithPantryCheckBox = new System.Windows.Forms.CheckBox();
            this.RecipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxButton_AddRecipe
            // 
            this.uxButton_AddRecipe.Location = new System.Drawing.Point(635, 610);
            this.uxButton_AddRecipe.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.uxButton_AddRecipe.Name = "uxButton_AddRecipe";
            this.uxButton_AddRecipe.Size = new System.Drawing.Size(310, 97);
            this.uxButton_AddRecipe.TabIndex = 2;
            this.uxButton_AddRecipe.Text = "Add Recipe";
            this.uxButton_AddRecipe.UseVisualStyleBackColor = true;
            this.uxButton_AddRecipe.Click += new System.EventHandler(this.uxButton_AddRecipe_Click);
            // 
            // recipeContextMenuStrip
            // 
            this.recipeContextMenuStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.recipeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.cookRecipeToolStripMenuItem});
            this.recipeContextMenuStrip.Name = "recipeContextMenuStrip";
            this.recipeContextMenuStrip.Size = new System.Drawing.Size(299, 108);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(298, 52);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cookRecipeToolStripMenuItem
            // 
            this.cookRecipeToolStripMenuItem.Name = "cookRecipeToolStripMenuItem";
            this.cookRecipeToolStripMenuItem.Size = new System.Drawing.Size(298, 52);
            this.cookRecipeToolStripMenuItem.Text = "Cook Recipe";
            this.cookRecipeToolStripMenuItem.Click += new System.EventHandler(this.cookRecipeToolStripMenuItem_Click);
            // 
            // RecipeDataGridView
            // 
            this.RecipeDataGridView.AutoGenerateColumns = false;
            this.RecipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeDataGridView.ColumnHeadersVisible = false;
            this.RecipeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Category});
            this.RecipeDataGridView.DataSource = this.RecipeBindingSource;
            this.RecipeDataGridView.Location = new System.Drawing.Point(86, 162);
            this.RecipeDataGridView.MultiSelect = false;
            this.RecipeDataGridView.Name = "RecipeDataGridView";
            this.RecipeDataGridView.RowTemplate.Height = 46;
            this.RecipeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecipeDataGridView.Size = new System.Drawing.Size(859, 405);
            this.RecipeDataGridView.TabIndex = 3;
            this.RecipeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipeDataGridView_CellDoubleClick);
            this.RecipeDataGridView.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.RecipeDataGridView_RowContextMenuStripNeeded);
            this.RecipeDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecipeDataGridView_MouseDown);
            // 
            // availableWithPantryCheckBox
            // 
            this.availableWithPantryCheckBox.AutoSize = true;
            this.availableWithPantryCheckBox.Location = new System.Drawing.Point(86, 62);
            this.availableWithPantryCheckBox.Name = "availableWithPantryCheckBox";
            this.availableWithPantryCheckBox.Size = new System.Drawing.Size(703, 41);
            this.availableWithPantryCheckBox.TabIndex = 4;
            this.availableWithPantryCheckBox.Text = "Only show recipes I can make with my pantry";
            this.availableWithPantryCheckBox.UseVisualStyleBackColor = true;
            this.availableWithPantryCheckBox.CheckedChanged += new System.EventHandler(this.availableWithPantryCheckBox_CheckedChanged);
            // 
            // RecipeBindingSource
            // 
            this.RecipeBindingSource.DataMember = "VisibleRecipes";
            this.RecipeBindingSource.DataSource = typeof(CIS560_RecipeManager.RecipeManager.RecipeInventory);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Visible = false;
            // 
            // uiRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 752);
            this.Controls.Add(this.availableWithPantryCheckBox);
            this.Controls.Add(this.RecipeDataGridView);
            this.Controls.Add(this.uxButton_AddRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "uiRecipe";
            this.Text = "Home";
            this.recipeContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uxButton_AddRecipe;
        private System.Windows.Forms.BindingSource RecipeBindingSource;
        private System.Windows.Forms.ContextMenuStrip recipeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookRecipeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView RecipeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox availableWithPantryCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}