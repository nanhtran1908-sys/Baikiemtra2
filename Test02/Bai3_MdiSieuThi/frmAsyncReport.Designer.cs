namespace Bai3_MdiSieuThi
{
    partial class frmAsyncReport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpReport = new GroupBox();
            dgvRevenue = new DataGridView();
            lblReportStatus = new Label();
            btnLoadReport = new Button();
            grpSync = new GroupBox();
            dgvOrders = new DataGridView();
            lblOrderCount = new Label();
            lblExchangeRate = new Label();
            btnStopSync = new Button();
            btnStartSync = new Button();
            grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).BeginInit();
            grpSync.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // grpReport
            // 
            grpReport.Controls.Add(dgvRevenue);
            grpReport.Controls.Add(lblReportStatus);
            grpReport.Controls.Add(btnLoadReport);
            grpReport.Location = new Point(14, 16);
            grpReport.Margin = new Padding(3, 4, 3, 4);
            grpReport.Name = "grpReport";
            grpReport.Padding = new Padding(3, 4, 3, 4);
            grpReport.Size = new Size(480, 715);
            grpReport.TabIndex = 0;
            grpReport.TabStop = false;
            grpReport.Text = "Báo cáo doanh thu (async/await)";
            // 
            // dgvRevenue
            // 
            dgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenue.Location = new Point(17, 120);
            dgvRevenue.Margin = new Padding(3, 4, 3, 4);
            dgvRevenue.Name = "dgvRevenue";
            dgvRevenue.RowHeadersWidth = 51;
            dgvRevenue.Size = new Size(446, 573);
            dgvRevenue.TabIndex = 2;
            // 
            // lblReportStatus
            // 
            lblReportStatus.AutoSize = true;
            lblReportStatus.Location = new Point(17, 84);
            lblReportStatus.Name = "lblReportStatus";
            lblReportStatus.Size = new Size(114, 20);
            lblReportStatus.TabIndex = 3;
            lblReportStatus.Text = "Chưa tải dữ liệu";
            // 
            // btnLoadReport
            // 
            btnLoadReport.Location = new Point(17, 33);
            btnLoadReport.Margin = new Padding(3, 4, 3, 4);
            btnLoadReport.Name = "btnLoadReport";
            btnLoadReport.Size = new Size(206, 34);
            btnLoadReport.TabIndex = 1;
            btnLoadReport.Text = "Tải Báo Cáo Doanh Thu";
            btnLoadReport.UseVisualStyleBackColor = true;
            // 
            // grpSync
            // 
            grpSync.Controls.Add(dgvOrders);
            grpSync.Controls.Add(lblOrderCount);
            grpSync.Controls.Add(lblExchangeRate);
            grpSync.Controls.Add(btnStopSync);
            grpSync.Controls.Add(btnStartSync);
            grpSync.Location = new Point(507, 16);
            grpSync.Margin = new Padding(3, 4, 3, 4);
            grpSync.Name = "grpSync";
            grpSync.Padding = new Padding(3, 4, 3, 4);
            grpSync.Size = new Size(496, 715);
            grpSync.TabIndex = 3;
            grpSync.TabStop = false;
            grpSync.Text = "Đồng bộ thời gian thực (Cross-Thread)";
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(17, 214);
            dgvOrders.Margin = new Padding(3, 4, 3, 4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(462, 479);
            dgvOrders.TabIndex = 6;
            // 
            // lblOrderCount
            // 
            lblOrderCount.AutoSize = true;
            lblOrderCount.Location = new Point(17, 172);
            lblOrderCount.Name = "lblOrderCount";
            lblOrderCount.Size = new Size(155, 20);
            lblOrderCount.TabIndex = 7;
            lblOrderCount.Text = "Tổng đơn hàng mới: 0";
            // 
            // lblExchangeRate
            // 
            lblExchangeRate.AutoSize = true;
            lblExchangeRate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblExchangeRate.Location = new Point(17, 135);
            lblExchangeRate.Name = "lblExchangeRate";
            lblExchangeRate.Size = new Size(185, 25);
            lblExchangeRate.TabIndex = 8;
            lblExchangeRate.Text = "Tỷ giá USD/VND: --";
            // 
            // btnStopSync
            // 
            btnStopSync.Enabled = false;
            btnStopSync.Location = new Point(17, 75);
            btnStopSync.Margin = new Padding(3, 4, 3, 4);
            btnStopSync.Name = "btnStopSync";
            btnStopSync.Size = new Size(114, 29);
            btnStopSync.TabIndex = 5;
            btnStopSync.Text = "Dừng";
            btnStopSync.UseVisualStyleBackColor = true;
            // 
            // btnStartSync
            // 
            btnStartSync.Location = new Point(17, 33);
            btnStartSync.Margin = new Padding(3, 4, 3, 4);
            btnStartSync.Name = "btnStartSync";
            btnStartSync.Size = new Size(171, 34);
            btnStartSync.TabIndex = 4;
            btnStartSync.Text = "Bắt đầu đồng bộ";
            btnStartSync.UseVisualStyleBackColor = true;
            // 
            // frmAsyncReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 747);
            Controls.Add(grpSync);
            Controls.Add(grpReport);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAsyncReport";
            Text = "Báo cáo thống kê & Đồng bộ";
            grpReport.ResumeLayout(false);
            grpReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).EndInit();
            grpSync.ResumeLayout(false);
            grpSync.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpReport;
        private Button btnLoadReport;
        private Label lblReportStatus;
        private DataGridView dgvRevenue;
        private GroupBox grpSync;
        private Button btnStartSync;
        private Button btnStopSync;
        private Label lblExchangeRate;
        private Label lblOrderCount;
        private DataGridView dgvOrders;
    }
}
