namespace CIS560_RecipeManager.RecipeManager
{
    partial class uiRecipeDetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RecipeDirectionsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RecipeIngredientsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 358);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 80);
            this.textBox1.TabIndex = 1;
            // 
            // RecipeDirectionsLabel
            // 
            this.RecipeDirectionsLabel.AutoSize = true;
            this.RecipeDirectionsLabel.Location = new System.Drawing.Point(33, 338);
            this.RecipeDirectionsLabel.Name = "RecipeDirectionsLabel";
            this.RecipeDirectionsLabel.Size = new System.Drawing.Size(57, 13);
            this.RecipeDirectionsLabel.TabIndex = 2;
            this.RecipeDirectionsLabel.Text = "Directions:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // RecipeIngredientsLabel
            // 
            this.RecipeIngredientsLabel.AutoSize = true;
            this.RecipeIngredientsLabel.Location = new System.Drawing.Point(33, 57);
            this.RecipeIngredientsLabel.Name = "RecipeIngredientsLabel";
            this.RecipeIngredientsLabel.Size = new System.Drawing.Size(65, 13);
            this.RecipeIngredientsLabel.TabIndex = 4;
            this.RecipeIngredientsLabel.Text = "Ingredients: ";
            // 
            // uiRecipeDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.RecipeIngredientsLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RecipeDirectionsLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "uiRecipeDetailForm";
            this.Text = "uiRecipeDetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RecipeDirectionsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label RecipeIngredientsLabel;
    }
}