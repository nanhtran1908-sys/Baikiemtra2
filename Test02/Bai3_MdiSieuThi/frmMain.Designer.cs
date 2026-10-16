namespace Bai3_MdiSieuThi
{
    partial class frmMain
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
            mnuMain = new MenuStrip();
            mnuSystem = new ToolStripMenuItem();
            mnuLogout = new ToolStripMenuItem();
            mnuSeparator1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuCatalog = new ToolStripMenuItem();
            mnuProducts = new ToolStripMenuItem();
            mnuStock = new ToolStripMenuItem();
            mnuReport = new ToolStripMenuItem();
            mnuRevenue = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            mnuTileHorizontal = new ToolStripMenuItem();
            mnuTileVertical = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            lblMessage = new ToolStripStatusLabel();
            lblSync = new ToolStripStatusLabel();
            prgLoading = new ToolStripProgressBar();
            mnuMain.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuSystem, mnuCatalog, mnuReport, mnuWindow });
            mnuMain.Location = new Point(0, 0);
            mnuMain.MdiWindowListItem = mnuWindow;
            mnuMain.Name = "mnuMain";
            mnuMain.Padding = new Padding(7, 3, 0, 3);
            mnuMain.Size = new Size(1353, 30);
            mnuMain.TabIndex = 0;
            // 
            // mnuSystem
            // 
            mnuSystem.DropDownItems.AddRange(new ToolStripItem[] { mnuLogout, mnuSeparator1, mnuExit });
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Size = new Size(85, 24);
            mnuSystem.Text = "&Hệ thống";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Size = new Size(224, 26);
            mnuLogout.Text = "Đăng xuất";
            // 
            // mnuSeparator1
            // 
            mnuSeparator1.Name = "mnuSeparator1";
            mnuSeparator1.Size = new Size(221, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(224, 26);
            mnuExit.Text = "Thoát";
            // 
            // mnuCatalog
            // 
            mnuCatalog.DropDownItems.AddRange(new ToolStripItem[] { mnuProducts, mnuStock });
            mnuCatalog.Name = "mnuCatalog";
            mnuCatalog.Size = new Size(90, 24);
            mnuCatalog.Text = "&Danh mục";
            // 
            // mnuProducts
            // 
            mnuProducts.Name = "mnuProducts";
            mnuProducts.Size = new Size(224, 26);
            mnuProducts.Text = "Quản lý Sản phẩm";
            // 
            // mnuStock
            // 
            mnuStock.Name = "mnuStock";
            mnuStock.Size = new Size(224, 26);
            mnuStock.Text = "Quản lý Nhập xuất";
            // 
            // mnuReport
            // 
            mnuReport.DropDownItems.AddRange(new ToolStripItem[] { mnuRevenue });
            mnuReport.Name = "mnuReport";
            mnuReport.Size = new Size(77, 24);
            mnuReport.Text = "&Báo cáo";
            // 
            // mnuRevenue
            // 
            mnuRevenue.Name = "mnuRevenue";
            mnuRevenue.Size = new Size(226, 26);
            mnuRevenue.Text = "Thống kê Doanh thu";
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuCascade, mnuTileHorizontal, mnuTileVertical });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(68, 24);
            mnuWindow.Text = "&Cửa sổ";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(190, 26);
            mnuCascade.Text = "Cascade";
            // 
            // mnuTileHorizontal
            // 
            mnuTileHorizontal.Name = "mnuTileHorizontal";
            mnuTileHorizontal.Size = new Size(190, 26);
            mnuTileHorizontal.Text = "Tile Horizontal";
            // 
            // mnuTileVertical
            // 
            mnuTileVertical.Name = "mnuTileVertical";
            mnuTileVertical.Size = new Size(190, 26);
            mnuTileVertical.Text = "Tile Vertical";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblUser, lblMessage, lblSync, prgLoading });
            statusStrip.Location = new Point(0, 918);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1353, 30);
            statusStrip.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(142, 24);
            lblUser.Text = "Người dùng: admin";
            // 
            // lblMessage
            // 
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(1194, 24);
            lblMessage.Spring = true;
            lblMessage.Text = "Sẵn sàng";
            lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSync
            // 
            lblSync.Name = "lblSync";
            lblSync.Size = new Size(0, 24);
            // 
            // prgLoading
            // 
            prgLoading.Name = "prgLoading";
            prgLoading.Size = new Size(229, 22);
            prgLoading.Visible = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 948);
            Controls.Add(statusStrip);
            Controls.Add(mnuMain);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý siêu thị";
            WindowState = FormWindowState.Maximized;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuSystem;
        private ToolStripMenuItem mnuLogout;
        private ToolStripSeparator mnuSeparator1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuCatalog;
        private ToolStripMenuItem mnuProducts;
        private ToolStripMenuItem mnuStock;
        private ToolStripMenuItem mnuReport;
        private ToolStripMenuItem mnuRevenue;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuCascade;
        private ToolStripMenuItem mnuTileHorizontal;
        private ToolStripMenuItem mnuTileVertical;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel lblMessage;
        private ToolStripStatusLabel lblSync;
        private ToolStripProgressBar prgLoading;
    }
}
