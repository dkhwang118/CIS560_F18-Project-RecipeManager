namespace CIS560_RecipeManager.Pantry
{
    partial class uiAddIngredient
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
            this.uxLabel_IngredientName = new System.Windows.Forms.Label();
            this.uxTextBox_IngredientName = new System.Windows.Forms.TextBox();
            this.uxLabel_UnitMeasurement = new System.Windows.Forms.Label();
            this.uxTextBox_UnitMeasurement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxLabel_PantryQuantity = new System.Windows.Forms.Label();
            this.uxTextBox_PantryQuantity = new System.Windows.Forms.TextBox();
            this.uxButton_AddIngredient = new System.Windows.Forms.Button();
            this.uxTextBox_PriceInCents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxLabel_IngredientName
            // 
            this.uxLabel_IngredientName.AutoSize = true;
            this.uxLabel_IngredientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel_IngredientName.Location = new System.Drawing.Point(66, 15);
            this.uxLabel_IngredientName.Name = "uxLabel_IngredientName";
            this.uxLabel_IngredientName.Size = new System.Drawing.Size(393, 55);
            this.uxLabel_IngredientName.TabIndex = 0;
            this.uxLabel_IngredientName.Text = "Ingredient Name:";
            // 
            // uxTextBox_IngredientName
            // 
            this.uxTextBox_IngredientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBox_IngredientName.Location = new System.Drawing.Point(203, 12);
            this.uxTextBox_IngredientName.Name = "uxTextBox_IngredientName";
            this.uxTextBox_IngredientName.Size = new System.Drawing.Size(432, 62);
            this.uxTextBox_IngredientName.TabIndex = 1;
            // 
            // uxLabel_UnitMeasurement
            // 
            this.uxLabel_UnitMeasurement.AutoSize = true;
            this.uxLabel_UnitMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel_UnitMeasurement.Location = new System.Drawing.Point(35, 47);
            this.uxLabel_UnitMeasurement.Name = "uxLabel_UnitMeasurement";
            this.uxLabel_UnitMeasurement.Size = new System.Drawing.Size(483, 55);
            this.uxLabel_UnitMeasurement.TabIndex = 2;
            this.uxLabel_UnitMeasurement.Text = "Unit of Measurement:";
            // 
            // uxTextBox_UnitMeasurement
            // 
            this.uxTextBox_UnitMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBox_UnitMeasurement.Location = new System.Drawing.Point(203, 44);
            this.uxTextBox_UnitMeasurement.Name = "uxTextBox_UnitMeasurement";
            this.uxTextBox_UnitMeasurement.Size = new System.Drawing.Size(432, 62);
            this.uxTextBox_UnitMeasurement.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(641, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "(e.g. cup, quart, ounce, gram, etc)";
            // 
            // uxLabel_PantryQuantity
            // 
            this.uxLabel_PantryQuantity.AutoSize = true;
            this.uxLabel_PantryQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel_PantryQuantity.Location = new System.Drawing.Point(19, 79);
            this.uxLabel_PantryQuantity.Name = "uxLabel_PantryQuantity";
            this.uxLabel_PantryQuantity.Size = new System.Drawing.Size(540, 55);
            this.uxLabel_PantryQuantity.TabIndex = 4;
            this.uxLabel_PantryQuantity.Text = "Initial Quantity in Pantry:";
            // 
            // uxTextBox_PantryQuantity
            // 
            this.uxTextBox_PantryQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBox_PantryQuantity.Location = new System.Drawing.Point(203, 76);
            this.uxTextBox_PantryQuantity.Name = "uxTextBox_PantryQuantity";
            this.uxTextBox_PantryQuantity.Size = new System.Drawing.Size(432, 62);
            this.uxTextBox_PantryQuantity.TabIndex = 5;
            // 
            // uxButton_AddIngredient
            // 
            this.uxButton_AddIngredient.Location = new System.Drawing.Point(203, 144);
            this.uxButton_AddIngredient.Name = "uxButton_AddIngredient";
            this.uxButton_AddIngredient.Size = new System.Drawing.Size(432, 33);
            this.uxButton_AddIngredient.TabIndex = 9;
            this.uxButton_AddIngredient.Text = "Add Ingredient to Pantry List";
            this.uxButton_AddIngredient.UseVisualStyleBackColor = true;
            this.uxButton_AddIngredient.Click += new System.EventHandler(this.uxButton_AddIngredient_Click);
            // 
            // uxTextBox_PriceInCents
            // 
            this.uxTextBox_PriceInCents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBox_PriceInCents.Location = new System.Drawing.Point(203, 105);
            this.uxTextBox_PriceInCents.Name = "uxTextBox_PriceInCents";
            this.uxTextBox_PriceInCents.Size = new System.Drawing.Size(432, 62);
            this.uxTextBox_PriceInCents.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 55);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price in Cents:";
            // 
            // uiAddIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxTextBox_PriceInCents);
            this.Controls.Add(this.uxButton_AddIngredient);
            this.Controls.Add(this.uxTextBox_PantryQuantity);
            this.Controls.Add(this.uxLabel_PantryQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxTextBox_UnitMeasurement);
            this.Controls.Add(this.uxLabel_UnitMeasurement);
            this.Controls.Add(this.uxTextBox_IngredientName);
            this.Controls.Add(this.uxLabel_IngredientName);
            this.Name = "uiAddIngredient";
            this.Text = "Add Ingredient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLabel_IngredientName;
        private System.Windows.Forms.TextBox uxTextBox_IngredientName;
        private System.Windows.Forms.Label uxLabel_UnitMeasurement;
        private System.Windows.Forms.TextBox uxTextBox_UnitMeasurement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uxLabel_PantryQuantity;
        private System.Windows.Forms.TextBox uxTextBox_PantryQuantity;
        private System.Windows.Forms.Button uxButton_AddIngredient;
        private System.Windows.Forms.TextBox uxTextBox_PriceInCents;
        private System.Windows.Forms.Label label2;
    }
}