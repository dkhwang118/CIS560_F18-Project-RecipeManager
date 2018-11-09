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
            this.RecipeDataGridView = new System.Windows.Forms.DataGridView();
            this.uxButton_AddRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipeDataGridView
            // 
            this.RecipeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipeDataGridView.Location = new System.Drawing.Point(58, 53);
            this.RecipeDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.RecipeDataGridView.Name = "RecipeDataGridView";
            this.RecipeDataGridView.RowTemplate.Height = 33;
            this.RecipeDataGridView.Size = new System.Drawing.Size(1144, 492);
            this.RecipeDataGridView.TabIndex = 1;
            this.RecipeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // uxButton_AddRecipe
            // 
            this.uxButton_AddRecipe.Location = new System.Drawing.Point(880, 576);
            this.uxButton_AddRecipe.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.uxButton_AddRecipe.Name = "uxButton_AddRecipe";
            this.uxButton_AddRecipe.Size = new System.Drawing.Size(311, 98);
            this.uxButton_AddRecipe.TabIndex = 2;
            this.uxButton_AddRecipe.Text = "Add Recipe";
            this.uxButton_AddRecipe.UseVisualStyleBackColor = true;
            this.uxButton_AddRecipe.Click += new System.EventHandler(this.uxButton_AddRecipe_Click);
            // 
            // uiRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 753);
            this.Controls.Add(this.uxButton_AddRecipe);
            this.Controls.Add(this.RecipeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "uiRecipe";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.RecipeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView RecipeDataGridView;
        private System.Windows.Forms.Button uxButton_AddRecipe;
    }
}