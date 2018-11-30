namespace CIS560_RecipeManager.StatsFormManager
{
    partial class uiStats
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
            this.StatsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StatsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StatsDataGridView
            // 
            this.StatsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatsDataGridView.Location = new System.Drawing.Point(441, 277);
            this.StatsDataGridView.Name = "StatsDataGridView";
            this.StatsDataGridView.RowTemplate.Height = 33;
            this.StatsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.StatsDataGridView.TabIndex = 0;
            // 
            // uiStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 697);
            this.Controls.Add(this.StatsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "uiStats";
            this.Text = "Statistics and Information";
            ((System.ComponentModel.ISupportInitialize)(this.StatsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StatsDataGridView;
    }
}