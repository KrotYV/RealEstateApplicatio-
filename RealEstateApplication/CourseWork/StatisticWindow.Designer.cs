namespace CourseWork
{
    partial class StatisticWindow
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
            this.dataGridViewStatistics = new System.Windows.Forms.DataGridView();
            this.caption = new System.Windows.Forms.Label();
            this.btnLongestRentedTypes = new System.Windows.Forms.Button();
            this.btnTopTenantsByRent = new System.Windows.Forms.Button();
            this.btnPopularPropertyTypes = new System.Windows.Forms.Button();
            this.btnProfitableTenantTypes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStatistics
            // 
            this.dataGridViewStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics.Location = new System.Drawing.Point(12, 302);
            this.dataGridViewStatistics.Name = "dataGridViewStatistics";
            this.dataGridViewStatistics.RowHeadersWidth = 82;
            this.dataGridViewStatistics.RowTemplate.Height = 33;
            this.dataGridViewStatistics.Size = new System.Drawing.Size(2076, 833);
            this.dataGridViewStatistics.TabIndex = 0;
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caption.Location = new System.Drawing.Point(981, 42);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(0, 54);
            this.caption.TabIndex = 1;
            // 
            // btnLongestRentedTypes
            // 
            this.btnLongestRentedTypes.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongestRentedTypes.Location = new System.Drawing.Point(12, 156);
            this.btnLongestRentedTypes.Name = "btnLongestRentedTypes";
            this.btnLongestRentedTypes.Size = new System.Drawing.Size(487, 126);
            this.btnLongestRentedTypes.TabIndex = 2;
            this.btnLongestRentedTypes.Text = "Show the longest rented types";
            this.btnLongestRentedTypes.UseVisualStyleBackColor = true;
            this.btnLongestRentedTypes.Click += new System.EventHandler(this.btnLongestRentedTypes_Click);
            // 
            // btnTopTenantsByRent
            // 
            this.btnTopTenantsByRent.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopTenantsByRent.Location = new System.Drawing.Point(532, 156);
            this.btnTopTenantsByRent.Name = "btnTopTenantsByRent";
            this.btnTopTenantsByRent.Size = new System.Drawing.Size(487, 126);
            this.btnTopTenantsByRent.TabIndex = 3;
            this.btnTopTenantsByRent.Text = "Show top tenants by rent";
            this.btnTopTenantsByRent.UseVisualStyleBackColor = true;
            this.btnTopTenantsByRent.Click += new System.EventHandler(this.btnTopTenantsByRent_Click);
            // 
            // btnPopularPropertyTypes
            // 
            this.btnPopularPropertyTypes.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopularPropertyTypes.Location = new System.Drawing.Point(1049, 156);
            this.btnPopularPropertyTypes.Name = "btnPopularPropertyTypes";
            this.btnPopularPropertyTypes.Size = new System.Drawing.Size(487, 126);
            this.btnPopularPropertyTypes.TabIndex = 4;
            this.btnPopularPropertyTypes.Text = "Show top popular property types";
            this.btnPopularPropertyTypes.UseVisualStyleBackColor = true;
            this.btnPopularPropertyTypes.Click += new System.EventHandler(this.btnPopularPropertyTypes_Click);
            // 
            // btnProfitableTenantTypes
            // 
            this.btnProfitableTenantTypes.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfitableTenantTypes.Location = new System.Drawing.Point(1564, 156);
            this.btnProfitableTenantTypes.Name = "btnProfitableTenantTypes";
            this.btnProfitableTenantTypes.Size = new System.Drawing.Size(487, 126);
            this.btnProfitableTenantTypes.TabIndex = 5;
            this.btnProfitableTenantTypes.Text = "Show profitable tenant types";
            this.btnProfitableTenantTypes.UseVisualStyleBackColor = true;
            this.btnProfitableTenantTypes.Click += new System.EventHandler(this.btnProfitableTenantTypes_Click);
            // 
            // StatisticWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(2096, 1273);
            this.Controls.Add(this.btnProfitableTenantTypes);
            this.Controls.Add(this.btnPopularPropertyTypes);
            this.Controls.Add(this.btnTopTenantsByRent);
            this.Controls.Add(this.btnLongestRentedTypes);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.dataGridViewStatistics);
            this.Name = "StatisticWindow";
            this.Text = "Statistic";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStatistics;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.Button btnLongestRentedTypes;
        private System.Windows.Forms.Button btnTopTenantsByRent;
        private System.Windows.Forms.Button btnPopularPropertyTypes;
        private System.Windows.Forms.Button btnProfitableTenantTypes;
    }
}