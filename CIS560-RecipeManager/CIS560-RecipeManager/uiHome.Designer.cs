namespace CIS560_RecipeManager
{
    partial class uiHome
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
            this.uxTextBox_dboFileLocation = new System.Windows.Forms.TextBox();
            this.manageRecipesButton = new System.Windows.Forms.Button();
            this.managePantryButton = new System.Windows.Forms.Button();
            this.manageShoppingListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTextBox_dboFileLocation
            // 
            this.uxTextBox_dboFileLocation.Location = new System.Drawing.Point(116, 457);
            this.uxTextBox_dboFileLocation.Margin = new System.Windows.Forms.Padding(2);
            this.uxTextBox_dboFileLocation.Name = "uxTextBox_dboFileLocation";
            this.uxTextBox_dboFileLocation.Size = new System.Drawing.Size(430, 20);
            this.uxTextBox_dboFileLocation.TabIndex = 0;
            // 
            // manageRecipesButton
            // 
            this.manageRecipesButton.Location = new System.Drawing.Point(40, 33);
            this.manageRecipesButton.Name = "manageRecipesButton";
            this.manageRecipesButton.Size = new System.Drawing.Size(290, 43);
            this.manageRecipesButton.TabIndex = 1;
            this.manageRecipesButton.Text = "Manage Recipes";
            this.manageRecipesButton.UseVisualStyleBackColor = true;
            this.manageRecipesButton.Click += new System.EventHandler(this.manageRecipesButton_Click);
            // 
            // managePantryButton
            // 
            this.managePantryButton.Location = new System.Drawing.Point(40, 105);
            this.managePantryButton.Name = "managePantryButton";
            this.managePantryButton.Size = new System.Drawing.Size(290, 43);
            this.managePantryButton.TabIndex = 2;
            this.managePantryButton.Text = "Manage Pantry";
            this.managePantryButton.UseVisualStyleBackColor = true;
            this.managePantryButton.Click += new System.EventHandler(this.managePantryButton_Click);
            // 
            // manageShoppingListButton
            // 
            this.manageShoppingListButton.Location = new System.Drawing.Point(40, 182);
            this.manageShoppingListButton.Name = "manageShoppingListButton";
            this.manageShoppingListButton.Size = new System.Drawing.Size(290, 43);
            this.manageShoppingListButton.TabIndex = 3;
            this.manageShoppingListButton.Text = "Manage Shopping Lists";
            this.manageShoppingListButton.UseVisualStyleBackColor = true;
            this.manageShoppingListButton.Click += new System.EventHandler(this.manageShoppingListButton_Click);
            // 
            // uiHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 263);
            this.Controls.Add(this.manageShoppingListButton);
            this.Controls.Add(this.managePantryButton);
            this.Controls.Add(this.manageRecipesButton);
            this.Controls.Add(this.uxTextBox_dboFileLocation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uiHome";
            this.Text = "Welcome to Your Recipe Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTextBox_dboFileLocation;
        private System.Windows.Forms.Button manageRecipesButton;
        private System.Windows.Forms.Button managePantryButton;
        private System.Windows.Forms.Button manageShoppingListButton;
    }
}

