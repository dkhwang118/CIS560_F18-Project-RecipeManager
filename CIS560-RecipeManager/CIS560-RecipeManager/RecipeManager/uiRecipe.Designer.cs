﻿namespace CIS560_RecipeManager
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
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ViewRecipeDetailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGridView)).BeginInit();
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
            this.RecipeDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RecipeDataGridView.MultiSelect = false;
            this.RecipeDataGridView.Name = "RecipeDataGridView";
            this.RecipeDataGridView.ReadOnly = true;
            this.RecipeDataGridView.RowTemplate.Height = 33;
            this.RecipeDataGridView.Size = new System.Drawing.Size(361, 173);
            this.RecipeDataGridView.TabIndex = 1;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "Category Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.Width = 96;
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
            // ViewRecipeDetailsButton
            // 
            this.ViewRecipeDetailsButton.Location = new System.Drawing.Point(131, 202);
            this.ViewRecipeDetailsButton.Name = "ViewRecipeDetailsButton";
            this.ViewRecipeDetailsButton.Size = new System.Drawing.Size(127, 34);
            this.ViewRecipeDetailsButton.TabIndex = 3;
            this.ViewRecipeDetailsButton.Text = "View Recipe Details";
            this.ViewRecipeDetailsButton.UseVisualStyleBackColor = true;
            this.ViewRecipeDetailsButton.Click += new System.EventHandler(this.ViewRecipeDetailsButton_Click);
            // 
            // uiRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 243);
            this.Controls.Add(this.ViewRecipeDetailsButton);
            this.Controls.Add(this.uxButton_AddRecipe);
            this.Controls.Add(this.RecipeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "uiRecipe";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView RecipeDataGridView;
        private System.Windows.Forms.Button uxButton_AddRecipe;
        private System.Windows.Forms.BindingSource RecipeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.Button ViewRecipeDetailsButton;
    }
}