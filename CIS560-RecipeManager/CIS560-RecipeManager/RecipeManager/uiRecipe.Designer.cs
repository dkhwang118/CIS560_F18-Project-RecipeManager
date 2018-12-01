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
            this.rateRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecipeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormattedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.availableWithPantryCheckBox = new System.Windows.Forms.CheckBox();
            this.budgetCheckBox = new System.Windows.Forms.CheckBox();
            this.uxDollarSelector = new System.Windows.Forms.NumericUpDown();
            this.recipeContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDollarSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // uxButton_AddRecipe
            // 
            this.uxButton_AddRecipe.Location = new System.Drawing.Point(328, 339);
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
            this.deleteToolStripMenuItem,
            this.cookRecipeToolStripMenuItem,
            this.rateRecipeToolStripMenuItem});
            this.recipeContextMenuStrip.Name = "recipeContextMenuStrip";
            this.recipeContextMenuStrip.Size = new System.Drawing.Size(299, 160);
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
            // rateRecipeToolStripMenuItem
            // 
            this.rateRecipeToolStripMenuItem.Name = "rateRecipeToolStripMenuItem";
            this.rateRecipeToolStripMenuItem.Size = new System.Drawing.Size(298, 52);
            this.rateRecipeToolStripMenuItem.Text = "Rate Recipe";
            this.rateRecipeToolStripMenuItem.Click += new System.EventHandler(this.rateRecipeToolStripMenuItem_Click);
            // 
            // RecipeDataGridView
            // 
            this.RecipeDataGridView.AutoGenerateColumns = false;
            this.RecipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Category,
            this.FormattedPrice,
            this.Rating});
            this.RecipeDataGridView.DataSource = this.RecipeBindingSource;
            this.RecipeDataGridView.Location = new System.Drawing.Point(27, 107);
            this.RecipeDataGridView.Margin = new System.Windows.Forms.Padding(1);
            this.RecipeDataGridView.MultiSelect = false;
            this.RecipeDataGridView.Name = "RecipeDataGridView";
            this.RecipeDataGridView.RowTemplate.Height = 46;
            this.RecipeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecipeDataGridView.Size = new System.Drawing.Size(399, 201);
            this.RecipeDataGridView.TabIndex = 3;
            this.RecipeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipeDataGridView_CellDoubleClick);
            this.RecipeDataGridView.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.RecipeDataGridView_RowContextMenuStripNeeded);
            this.RecipeDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RecipeDataGridView_MouseDown);
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
            // FormattedPrice
            // 
            this.FormattedPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FormattedPrice.DataPropertyName = "FormattedPrice";
            this.FormattedPrice.HeaderText = "Price";
            this.FormattedPrice.Name = "FormattedPrice";
            this.FormattedPrice.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rating.DataPropertyName = "Rating";
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // RecipeBindingSource
            // 
            this.RecipeBindingSource.DataMember = "VisibleRecipes";
            this.RecipeBindingSource.DataSource = typeof(CIS560_RecipeManager.RecipeManager.RecipeInventory);
            // 
            // availableWithPantryCheckBox
            // 
            this.availableWithPantryCheckBox.AutoSize = true;
            this.availableWithPantryCheckBox.Location = new System.Drawing.Point(27, 22);
            this.availableWithPantryCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.availableWithPantryCheckBox.Name = "availableWithPantryCheckBox";
            this.availableWithPantryCheckBox.Size = new System.Drawing.Size(265, 41);
            this.availableWithPantryCheckBox.TabIndex = 4;
            this.availableWithPantryCheckBox.Text = "Only show recipes I can make with my pantry";
            this.availableWithPantryCheckBox.UseVisualStyleBackColor = true;
            this.availableWithPantryCheckBox.CheckedChanged += new System.EventHandler(this.availableWithPantryCheckBox_CheckedChanged);
            // 
            // budgetCheckBox
            // 
            this.budgetCheckBox.AutoSize = true;
            this.budgetCheckBox.Location = new System.Drawing.Point(27, 64);
            this.budgetCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.budgetCheckBox.Name = "budgetCheckBox";
            this.budgetCheckBox.Size = new System.Drawing.Size(272, 41);
            this.budgetCheckBox.TabIndex = 5;
            this.budgetCheckBox.Text = "Only show recipes with a dollar cost less than: ";
            this.budgetCheckBox.UseVisualStyleBackColor = true;
            this.budgetCheckBox.CheckedChanged += new System.EventHandler(this.budgetCheckBox_CheckedChanged);
            // 
            // uxDollarSelector
            // 
            this.uxDollarSelector.Location = new System.Drawing.Point(275, 60);
            this.uxDollarSelector.Name = "uxDollarSelector";
            this.uxDollarSelector.Size = new System.Drawing.Size(120, 20);
            this.uxDollarSelector.TabIndex = 6;
            // 
            // uiRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 386);
            this.Controls.Add(this.uxDollarSelector);
            this.Controls.Add(this.budgetCheckBox);
            this.Controls.Add(this.availableWithPantryCheckBox);
            this.Controls.Add(this.RecipeDataGridView);
            this.Controls.Add(this.uxButton_AddRecipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "uiRecipe";
            this.Text = "Home";
            this.recipeContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDollarSelector)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem rateRecipeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormattedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.CheckBox budgetCheckBox;
        private System.Windows.Forms.NumericUpDown uxDollarSelector;
    }
}