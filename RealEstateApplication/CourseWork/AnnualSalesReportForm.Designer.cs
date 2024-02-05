namespace CourseWork
{
    partial class AnnualSalesReportForm
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
            this.dataGridViewAnnualReport = new System.Windows.Forms.DataGridView();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnnualReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnnualReport
            // 
            this.dataGridViewAnnualReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnnualReport.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewAnnualReport.Name = "dataGridViewAnnualReport";
            this.dataGridViewAnnualReport.RowHeadersWidth = 82;
            this.dataGridViewAnnualReport.RowTemplate.Height = 33;
            this.dataGridViewAnnualReport.Size = new System.Drawing.Size(1523, 1378);
            this.dataGridViewAnnualReport.TabIndex = 0;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(626, 12);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(174, 69);
            this.btnSaveToFile.TabIndex = 1;
            this.btnSaveToFile.Text = "Save report";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // AnnualSalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1885, 1493);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.dataGridViewAnnualReport);
            this.Name = "AnnualSalesReportForm";
            this.Text = "AnnualSalesReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnnualReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnnualReport;
        private System.Windows.Forms.Button btnSaveToFile;
    }
}