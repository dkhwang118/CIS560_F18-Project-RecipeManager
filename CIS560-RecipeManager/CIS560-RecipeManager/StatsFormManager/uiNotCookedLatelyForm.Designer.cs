namespace CIS560_RecipeManager.StatsFormManager
{
    partial class uiNotCookedLatelyForm
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
            this.uxButton_ShowLeastRecentCookedRecipes = new System.Windows.Forms.Button();
            this.uxButton_ShowUncookedRecipes = new System.Windows.Forms.Button();
            this.uxDGV_RecipesCookedStatsOutput = new System.Windows.Forms.DataGridView();
            this.RecentlyCookedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxDGV_RecipesCookedStatsOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecentlyCookedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxButton_ShowLeastRecentCookedRecipes
            // 
            this.uxButton_ShowLeastRecentCookedRecipes.Location = new System.Drawing.Point(30, 41);
            this.uxButton_ShowLeastRecentCookedRecipes.Name = "uxButton_ShowLeastRecentCookedRecipes";
            this.uxButton_ShowLeastRecentCookedRecipes.Size = new System.Drawing.Size(382, 79);
            this.uxButton_ShowLeastRecentCookedRecipes.TabIndex = 0;
            this.uxButton_ShowLeastRecentCookedRecipes.Text = "Show Recipes that have not been cooked recently";
            this.uxButton_ShowLeastRecentCookedRecipes.UseVisualStyleBackColor = true;
            this.uxButton_ShowLeastRecentCookedRecipes.Click += new System.EventHandler(this.uxButton_ShowLeastRecentCookedRecipes_Click);
            // 
            // uxButton_ShowUncookedRecipes
            // 
            this.uxButton_ShowUncookedRecipes.Location = new System.Drawing.Point(30, 161);
            this.uxButton_ShowUncookedRecipes.Name = "uxButton_ShowUncookedRecipes";
            this.uxButton_ShowUncookedRecipes.Size = new System.Drawing.Size(382, 79);
            this.uxButton_ShowUncookedRecipes.TabIndex = 1;
            this.uxButton_ShowUncookedRecipes.Text = "Show Recipes that have not been cooked";
            this.uxButton_ShowUncookedRecipes.UseVisualStyleBackColor = true;
            this.uxButton_ShowUncookedRecipes.Click += new System.EventHandler(this.uxButton_ShowUncookedRecipes_Click);
            // 
            // uxDGV_RecipesCookedStatsOutput
            // 
            this.uxDGV_RecipesCookedStatsOutput.AllowUserToAddRows = false;
            this.uxDGV_RecipesCookedStatsOutput.AllowUserToDeleteRows = false;
            this.uxDGV_RecipesCookedStatsOutput.AllowUserToResizeColumns = false;
            this.uxDGV_RecipesCookedStatsOutput.AllowUserToResizeRows = false;
            this.uxDGV_RecipesCookedStatsOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxDGV_RecipesCookedStatsOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDGV_RecipesCookedStatsOutput.Location = new System.Drawing.Point(492, 41);
            this.uxDGV_RecipesCookedStatsOutput.Name = "uxDGV_RecipesCookedStatsOutput";
            this.uxDGV_RecipesCookedStatsOutput.ReadOnly = true;
            this.uxDGV_RecipesCookedStatsOutput.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.uxDGV_RecipesCookedStatsOutput.RowTemplate.Height = 33;
            this.uxDGV_RecipesCookedStatsOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxDGV_RecipesCookedStatsOutput.Size = new System.Drawing.Size(800, 669);
            this.uxDGV_RecipesCookedStatsOutput.TabIndex = 2;
            this.uxDGV_RecipesCookedStatsOutput.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxDGV_RecipesCookedStatsOutput_CellDoubleClick);
            // 
            // uiNotCookedLatelyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 749);
            this.Controls.Add(this.uxDGV_RecipesCookedStatsOutput);
            this.Controls.Add(this.uxButton_ShowUncookedRecipes);
            this.Controls.Add(this.uxButton_ShowLeastRecentCookedRecipes);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "uiNotCookedLatelyForm";
            this.Text = "What have I not cooked lately?";
            ((System.ComponentModel.ISupportInitialize)(this.uxDGV_RecipesCookedStatsOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecentlyCookedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxButton_ShowLeastRecentCookedRecipes;
        private System.Windows.Forms.Button uxButton_ShowUncookedRecipes;
        private System.Windows.Forms.DataGridView uxDGV_RecipesCookedStatsOutput;
        private System.Windows.Forms.BindingSource RecentlyCookedBindingSource;
    }
}