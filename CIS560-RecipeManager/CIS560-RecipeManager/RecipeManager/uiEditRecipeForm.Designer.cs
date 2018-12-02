namespace CIS560_RecipeManager
{
    partial class uiEditRecipeForm
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
            this.uxTextBox_RecipeName = new System.Windows.Forms.TextBox();
            this.uxLabel_RecipeName = new System.Windows.Forms.Label();
            this.uxButton_EditRecipeOK = new System.Windows.Forms.Button();
            this.uxLabel_RecipeDescription = new System.Windows.Forms.Label();
            this.uxTextBox_RecipeDescription = new System.Windows.Forms.TextBox();
            this.totalIngredientsDGV = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormattedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.recipeIngredientsDGV = new System.Windows.Forms.DataGridView();
            this.recipeIngredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.addIngredientButton = new System.Windows.Forms.Button();
            this.ingredientContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientsBindingSource)).BeginInit();
            this.ingredientContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxTextBox_RecipeName
            // 
            this.uxTextBox_RecipeName.Location = new System.Drawing.Point(141, 18);
            this.uxTextBox_RecipeName.Name = "uxTextBox_RecipeName";
            this.uxTextBox_RecipeName.Size = new System.Drawing.Size(365, 20);
            this.uxTextBox_RecipeName.TabIndex = 0;
            // 
            // uxLabel_RecipeName
            // 
            this.uxLabel_RecipeName.AutoSize = true;
            this.uxLabel_RecipeName.Location = new System.Drawing.Point(37, 21);
            this.uxLabel_RecipeName.Name = "uxLabel_RecipeName";
            this.uxLabel_RecipeName.Size = new System.Drawing.Size(75, 13);
            this.uxLabel_RecipeName.TabIndex = 1;
            this.uxLabel_RecipeName.Text = "Recipe Name:";
            // 
            // uxButton_EditRecipeOK
            // 
            this.uxButton_EditRecipeOK.Location = new System.Drawing.Point(423, 461);
            this.uxButton_EditRecipeOK.Name = "uxButton_EditRecipeOK";
            this.uxButton_EditRecipeOK.Size = new System.Drawing.Size(94, 28);
            this.uxButton_EditRecipeOK.TabIndex = 2;
            this.uxButton_EditRecipeOK.Text = "OK";
            this.uxButton_EditRecipeOK.UseVisualStyleBackColor = true;
            this.uxButton_EditRecipeOK.Click += new System.EventHandler(this.uxOKButton_Click);
            // 
            // uxLabel_RecipeDescription
            // 
            this.uxLabel_RecipeDescription.AutoSize = true;
            this.uxLabel_RecipeDescription.Location = new System.Drawing.Point(85, 340);
            this.uxLabel_RecipeDescription.Name = "uxLabel_RecipeDescription";
            this.uxLabel_RecipeDescription.Size = new System.Drawing.Size(100, 13);
            this.uxLabel_RecipeDescription.TabIndex = 3;
            this.uxLabel_RecipeDescription.Text = "Recipe Description:";
            // 
            // uxTextBox_RecipeDescription
            // 
            this.uxTextBox_RecipeDescription.Location = new System.Drawing.Point(88, 366);
            this.uxTextBox_RecipeDescription.Multiline = true;
            this.uxTextBox_RecipeDescription.Name = "uxTextBox_RecipeDescription";
            this.uxTextBox_RecipeDescription.Size = new System.Drawing.Size(379, 76);
            this.uxTextBox_RecipeDescription.TabIndex = 4;
            // 
            // totalIngredientsDGV
            // 
            this.totalIngredientsDGV.AutoGenerateColumns = false;
            this.totalIngredientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.totalIngredientsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.FormattedPrice});
            this.totalIngredientsDGV.DataSource = this.totalIngredientsBindingSource;
            this.totalIngredientsDGV.Location = new System.Drawing.Point(39, 135);
            this.totalIngredientsDGV.Margin = new System.Windows.Forms.Padding(1);
            this.totalIngredientsDGV.Name = "totalIngredientsDGV";
            this.totalIngredientsDGV.ReadOnly = true;
            this.totalIngredientsDGV.RowHeadersVisible = false;
            this.totalIngredientsDGV.RowTemplate.Height = 46;
            this.totalIngredientsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.totalIngredientsDGV.Size = new System.Drawing.Size(219, 155);
            this.totalIngredientsDGV.TabIndex = 5;
            this.totalIngredientsDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.totalIngredientsDGV_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormattedPrice
            // 
            this.FormattedPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FormattedPrice.DataPropertyName = "FormattedPrice";
            this.FormattedPrice.HeaderText = "Price";
            this.FormattedPrice.Name = "FormattedPrice";
            this.FormattedPrice.ReadOnly = true;
            // 
            // totalIngredientsBindingSource
            // 
            this.totalIngredientsBindingSource.DataMember = "TotalIngredients";
            this.totalIngredientsBindingSource.DataSource = typeof(CIS560_RecipeManager.RecipeManager.EditRecipeViewModel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "All Ingredients:";
            // 
            // recipeIngredientsDGV
            // 
            this.recipeIngredientsDGV.AllowUserToAddRows = false;
            this.recipeIngredientsDGV.AutoGenerateColumns = false;
            this.recipeIngredientsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeIngredientsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.unitDataGridViewTextBoxColumn2,
            this.Quantity});
            this.recipeIngredientsDGV.DataSource = this.recipeIngredientsBindingSource;
            this.recipeIngredientsDGV.Location = new System.Drawing.Point(287, 135);
            this.recipeIngredientsDGV.Margin = new System.Windows.Forms.Padding(1);
            this.recipeIngredientsDGV.Name = "recipeIngredientsDGV";
            this.recipeIngredientsDGV.RowHeadersVisible = false;
            this.recipeIngredientsDGV.RowTemplate.Height = 46;
            this.recipeIngredientsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recipeIngredientsDGV.Size = new System.Drawing.Size(219, 155);
            this.recipeIngredientsDGV.TabIndex = 7;
            this.recipeIngredientsDGV.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.recipeIngredientsDGV_RowContextMenuStripNeeded);
            this.recipeIngredientsDGV.BindingContextChanged += new System.EventHandler(this.recipeIngredientsDGV_BindingContextChanged);
            // 
            // recipeIngredientsBindingSource
            // 
            this.recipeIngredientsBindingSource.DataMember = "RecipeIngredients";
            this.recipeIngredientsBindingSource.DataSource = typeof(CIS560_RecipeManager.RecipeManager.EditRecipeViewModel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingredients in Recipe:";
            // 
            // addIngredientButton
            // 
            this.addIngredientButton.Location = new System.Drawing.Point(170, 303);
            this.addIngredientButton.Name = "addIngredientButton";
            this.addIngredientButton.Size = new System.Drawing.Size(219, 27);
            this.addIngredientButton.TabIndex = 9;
            this.addIngredientButton.Text = "Add New Ingredient";
            this.addIngredientButton.UseVisualStyleBackColor = true;
            this.addIngredientButton.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // ingredientContextMenuStrip
            // 
            this.ingredientContextMenuStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.ingredientContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.ingredientContextMenuStrip.Name = "ingredientContextMenuStrip";
            this.ingredientContextMenuStrip.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Recipe Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(141, 64);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(365, 21);
            this.categoryComboBox.TabIndex = 11;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn2
            // 
            this.unitDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitDataGridViewTextBoxColumn1.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn1.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn1.Name = "unitDataGridViewTextBoxColumn1";
            this.unitDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            this.unitDataGridViewTextBoxColumn2.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn2.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn2.Name = "unitDataGridViewTextBoxColumn2";
            this.unitDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // uiEditRecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(573, 512);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addIngredientButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recipeIngredientsDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalIngredientsDGV);
            this.Controls.Add(this.uxTextBox_RecipeDescription);
            this.Controls.Add(this.uxLabel_RecipeDescription);
            this.Controls.Add(this.uxButton_EditRecipeOK);
            this.Controls.Add(this.uxLabel_RecipeName);
            this.Controls.Add(this.uxTextBox_RecipeName);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "uiEditRecipeForm";
            this.Text = "Add or Update Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIngredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeIngredientsBindingSource)).EndInit();
            this.ingredientContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextBox_RecipeName;
        private System.Windows.Forms.Label uxLabel_RecipeName;
        private System.Windows.Forms.Button uxButton_EditRecipeOK;
        private System.Windows.Forms.Label uxLabel_RecipeDescription;
        private System.Windows.Forms.TextBox uxTextBox_RecipeDescription;
        private System.Windows.Forms.DataGridView totalIngredientsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView recipeIngredientsDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addIngredientButton;
        private System.Windows.Forms.BindingSource totalIngredientsBindingSource;
        private System.Windows.Forms.BindingSource recipeIngredientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ContextMenuStrip ingredientContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormattedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn2;
    }
}