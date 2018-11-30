namespace CIS560_RecipeManager
{
    partial class uiPantry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uxPantryItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.uxButton_AddIngredient = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pantryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxPantryItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantryItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxPantryItemsDataGridView
            // 
            this.uxPantryItemsDataGridView.AllowUserToAddRows = false;
            this.uxPantryItemsDataGridView.AllowUserToResizeColumns = false;
            this.uxPantryItemsDataGridView.AllowUserToResizeRows = false;
            this.uxPantryItemsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxPantryItemsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uxPantryItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.uxPantryItemsDataGridView.ColumnHeadersHeight = 40;
            this.uxPantryItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uxPantryItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.Quantity});
            this.uxPantryItemsDataGridView.DataSource = this.pantryItemBindingSource;
            this.uxPantryItemsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.uxPantryItemsDataGridView.MultiSelect = false;
            this.uxPantryItemsDataGridView.Name = "uxPantryItemsDataGridView";
            this.uxPantryItemsDataGridView.RowHeadersVisible = false;
            this.uxPantryItemsDataGridView.RowHeadersWidth = 120;
            this.uxPantryItemsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.uxPantryItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uxPantryItemsDataGridView.Size = new System.Drawing.Size(529, 317);
            this.uxPantryItemsDataGridView.TabIndex = 0;
            this.uxPantryItemsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxPantryItemsDataGridView_CellEndEdit);
            this.uxPantryItemsDataGridView.BindingContextChanged += new System.EventHandler(this.uxPantryItemsDataGridView_BindingContextChanged);
            // 
            // uxButton_AddIngredient
            // 
            this.uxButton_AddIngredient.Location = new System.Drawing.Point(399, 337);
            this.uxButton_AddIngredient.Margin = new System.Windows.Forms.Padding(1);
            this.uxButton_AddIngredient.Name = "uxButton_AddIngredient";
            this.uxButton_AddIngredient.Size = new System.Drawing.Size(142, 41);
            this.uxButton_AddIngredient.TabIndex = 1;
            this.uxButton_AddIngredient.Text = "Add Ingredient";
            this.uxButton_AddIngredient.UseVisualStyleBackColor = true;
            this.uxButton_AddIngredient.Click += new System.EventHandler(this.addIngredientButton_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FormattedPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // pantryItemBindingSource
            // 
            this.pantryItemBindingSource.DataMember = "IngredientList";
            this.pantryItemBindingSource.DataSource = typeof(CIS560_RecipeManager.PantryManager.PantryViewModel);
            // 
            // uiPantry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 381);
            this.Controls.Add(this.uxButton_AddIngredient);
            this.Controls.Add(this.uxPantryItemsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "uiPantry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pantry Items";
            ((System.ComponentModel.ISupportInitialize)(this.uxPantryItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pantryItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView uxPantryItemsDataGridView;
        private System.Windows.Forms.BindingSource pantryItemBindingSource;
        private System.Windows.Forms.Button uxButton_AddIngredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceInCentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formattedPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}