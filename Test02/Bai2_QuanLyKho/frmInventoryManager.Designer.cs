namespace Bai2_QuanLyKho
{
    partial class frmInventoryManager
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
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            mnuSystem = new ToolStripMenuItem();
            mnuOpenFile = new ToolStripMenuItem();
            mnuSaveReport = new ToolStripMenuItem();
            mnuSeparator1 = new ToolStripSeparator();
            mnuExit = new ToolStripMenuItem();
            mnuTools = new ToolStripMenuItem();
            mnuImportCsv = new ToolStripMenuItem();
            mnuExportCsv = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            tsbOpen = new ToolStripButton();
            tsbSave = new ToolStripButton();
            tsbSeparator1 = new ToolStripSeparator();
            tsbImport = new ToolStripButton();
            tsbExport = new ToolStripButton();
            tsbSeparator2 = new ToolStripSeparator();
            tsbExit = new ToolStripButton();
            statusStrip = new StatusStrip();
            lblTotalQuantity = new ToolStripStatusLabel();
            lblTotalValue = new ToolStripStatusLabel();
            lblSpacer = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            grpInput = new GroupBox();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtProductId = new TextBox();
            lblProductId = new Label();
            grpImage = new GroupBox();
            btnChooseImage = new Button();
            picProductImage = new PictureBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvProducts = new DataGridView();
            errProvider = new ErrorProvider(components);
            tmrClock = new System.Windows.Forms.Timer(components);
            ofdImage = new OpenFileDialog();
            grpProductList = new GroupBox();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            grpProductList.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuSystem, mnuTools });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 3, 0, 3);
            menuStrip.Size = new Size(1143, 30);
            menuStrip.TabIndex = 0;
            // 
            // mnuSystem
            // 
            mnuSystem.DropDownItems.AddRange(new ToolStripItem[] { mnuOpenFile, mnuSaveReport, mnuSeparator1, mnuExit });
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Size = new Size(70, 24);
            mnuSystem.Text = "&System";
            // 
            // mnuOpenFile
            // 
            mnuOpenFile.Name = "mnuOpenFile";
            mnuOpenFile.ShortcutKeys = Keys.Control | Keys.O;
            mnuOpenFile.Size = new Size(222, 26);
            mnuOpenFile.Text = "Open File";
            // 
            // mnuSaveReport
            // 
            mnuSaveReport.Name = "mnuSaveReport";
            mnuSaveReport.ShortcutKeys = Keys.Control | Keys.S;
            mnuSaveReport.Size = new Size(222, 26);
            mnuSaveReport.Text = "Save Report";
            // 
            // mnuSeparator1
            // 
            mnuSeparator1.Name = "mnuSeparator1";
            mnuSeparator1.Size = new Size(219, 6);
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(222, 26);
            mnuExit.Text = "Exit";
            // 
            // mnuTools
            // 
            mnuTools.DropDownItems.AddRange(new ToolStripItem[] { mnuImportCsv, mnuExportCsv });
            mnuTools.Name = "mnuTools";
            mnuTools.Size = new Size(58, 24);
            mnuTools.Text = "&Tools";
            // 
            // mnuImportCsv
            // 
            mnuImportCsv.Name = "mnuImportCsv";
            mnuImportCsv.ShortcutKeys = Keys.Control | Keys.I;
            mnuImportCsv.Size = new Size(215, 26);
            mnuImportCsv.Text = "Import CSV";
            // 
            // mnuExportCsv
            // 
            mnuExportCsv.Name = "mnuExportCsv";
            mnuExportCsv.ShortcutKeys = Keys.Control | Keys.E;
            mnuExportCsv.Size = new Size(215, 26);
            mnuExportCsv.Text = "Export CSV";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { tsbOpen, tsbSave, tsbSeparator1, tsbImport, tsbExport, tsbSeparator2, tsbExit });
            toolStrip.Location = new Point(0, 30);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1143, 27);
            toolStrip.TabIndex = 1;
            // 
            // tsbOpen
            // 
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new Size(35, 24);
            tsbOpen.Text = "Mở";
            tsbOpen.ToolTipText = "Mở file dữ liệu (JSON)";
            // 
            // tsbSave
            // 
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(95, 24);
            tsbSave.Text = "Lưu báo cáo";
            tsbSave.ToolTipText = "Lưu báo cáo tổng hợp";
            // 
            // tsbSeparator1
            // 
            tsbSeparator1.Name = "tsbSeparator1";
            tsbSeparator1.Size = new Size(6, 27);
            // 
            // tsbImport
            // 
            tsbImport.Name = "tsbImport";
            tsbImport.Size = new Size(79, 24);
            tsbImport.Text = "Nhập CSV";
            tsbImport.ToolTipText = "Nhập dữ liệu từ file CSV";
            // 
            // tsbExport
            // 
            tsbExport.Name = "tsbExport";
            tsbExport.Size = new Size(73, 24);
            tsbExport.Text = "Xuất CSV";
            tsbExport.ToolTipText = "Xuất danh sách ra file CSV";
            // 
            // tsbSeparator2
            // 
            tsbSeparator2.Name = "tsbSeparator2";
            tsbSeparator2.Size = new Size(6, 27);
            // 
            // tsbExit
            // 
            tsbExit.Name = "tsbExit";
            tsbExit.Size = new Size(51, 24);
            tsbExit.Text = "Thoát";
            tsbExit.ToolTipText = "Thoát chương trình";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { lblTotalQuantity, lblTotalValue, lblSpacer, lblClock });
            statusStrip.Location = new Point(0, 877);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(1143, 30);
            statusStrip.TabIndex = 2;
            // 
            // lblTotalQuantity
            // 
            lblTotalQuantity.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblTotalQuantity.Name = "lblTotalQuantity";
            lblTotalQuantity.Size = new Size(124, 24);
            lblTotalQuantity.Text = "Tổng số lượng: 0";
            // 
            // lblTotalValue
            // 
            lblTotalValue.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(146, 24);
            lblTotalValue.Text = "Tổng giá trị kho: 0 ₫";
            // 
            // lblSpacer
            // 
            lblSpacer.Name = "lblSpacer";
            lblSpacer.Size = new Size(793, 24);
            lblSpacer.Spring = true;
            // 
            // lblClock
            // 
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(63, 24);
            lblClock.Text = "00:00:00";
            // 
            // grpInput
            // 
            grpInput.Controls.Add(numQuantity);
            grpInput.Controls.Add(lblQuantity);
            grpInput.Controls.Add(txtPrice);
            grpInput.Controls.Add(lblPrice);
            grpInput.Controls.Add(cboCategory);
            grpInput.Controls.Add(lblCategory);
            grpInput.Controls.Add(txtProductName);
            grpInput.Controls.Add(lblProductName);
            grpInput.Controls.Add(txtProductId);
            grpInput.Controls.Add(lblProductId);
            grpInput.Location = new Point(14, 80);
            grpInput.Margin = new Padding(3, 4, 3, 4);
            grpInput.Name = "grpInput";
            grpInput.Padding = new Padding(3, 4, 3, 4);
            grpInput.Size = new Size(772, 280);
            grpInput.TabIndex = 3;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin sản phẩm";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(160, 227);
            numQuantity.Margin = new Padding(3, 4, 3, 4);
            numQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(261, 27);
            numQuantity.TabIndex = 7;
            numQuantity.TextAlign = HorizontalAlignment.Right;
            numQuantity.ThousandsSeparator = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(23, 231);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(98, 20);
            lblQuantity.TabIndex = 8;
            lblQuantity.Text = "Số lượng tồn:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(160, 180);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(351, 27);
            txtPrice.TabIndex = 6;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(23, 184);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(65, 20);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Đơn giá:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(160, 133);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(351, 28);
            cboCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(23, 137);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(108, 20);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Loại sản phẩm:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(160, 87);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.MaxLength = 100;
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(348, 27);
            txtProductName.TabIndex = 4;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(23, 91);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(103, 20);
            lblProductName.TabIndex = 11;
            lblProductName.Text = "Tên sản phẩm:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(160, 40);
            txtProductId.Margin = new Padding(3, 4, 3, 4);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(348, 27);
            txtProductId.TabIndex = 99;
            txtProductId.TabStop = false;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(23, 44);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(101, 20);
            lblProductId.TabIndex = 100;
            lblProductId.Text = "Mã sản phẩm:";
            // 
            // grpImage
            // 
            grpImage.Controls.Add(btnChooseImage);
            grpImage.Controls.Add(picProductImage);
            grpImage.Location = new Point(792, 80);
            grpImage.Margin = new Padding(3, 4, 3, 4);
            grpImage.Name = "grpImage";
            grpImage.Padding = new Padding(3, 4, 3, 4);
            grpImage.Size = new Size(310, 280);
            grpImage.TabIndex = 8;
            grpImage.TabStop = false;
            grpImage.Text = "Ảnh sản phẩm";
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(65, 223);
            btnChooseImage.Margin = new Padding(3, 4, 3, 4);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(206, 43);
            btnChooseImage.TabIndex = 10;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            // 
            // picProductImage
            // 
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            picProductImage.Location = new Point(11, 29);
            picProductImage.Margin = new Padding(3, 4, 3, 4);
            picProductImage.Name = "picProductImage";
            picProductImage.Size = new Size(287, 186);
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.TabIndex = 9;
            picProductImage.TabStop = false;
            picProductImage.Click += picProductImage_Click;
            // 
            // btnClear
            // 
            btnClear.CausesValidation = false;
            btnClear.Location = new Point(803, 368);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(183, 48);
            btnClear.TabIndex = 15;
            btnClear.Text = "Làm mới / Hủy";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.CausesValidation = false;
            btnDelete.Location = new Point(543, 368);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(183, 48);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(282, 368);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(183, 48);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(37, 368);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(183, 48);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.CausesValidation = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(11, 27);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(1077, 400);
            dgvProducts.TabIndex = 16;
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // tmrClock
            // 
            tmrClock.Interval = 1000;
            // 
            // ofdImage
            // 
            ofdImage.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            ofdImage.Title = "Chọn ảnh sản phẩm";
            // 
            // grpProductList
            // 
            grpProductList.Controls.Add(dgvProducts);
            grpProductList.Location = new Point(14, 440);
            grpProductList.Name = "grpProductList";
            grpProductList.Size = new Size(1104, 434);
            grpProductList.TabIndex = 17;
            grpProductList.TabStop = false;
            grpProductList.Text = "Danh sách sản phẩm trong kho";
            // 
            // frmInventoryManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 907);
            Controls.Add(grpProductList);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(grpImage);
            Controls.Add(btnAdd);
            Controls.Add(grpInput);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmInventoryManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý kho hàng";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            grpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            grpProductList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuSystem;
        private ToolStripMenuItem mnuOpenFile;
        private ToolStripMenuItem mnuSaveReport;
        private ToolStripSeparator mnuSeparator1;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuTools;
        private ToolStripMenuItem mnuImportCsv;
        private ToolStripMenuItem mnuExportCsv;
        private ToolStrip toolStrip;
        private ToolStripButton tsbOpen;
        private ToolStripButton tsbSave;
        private ToolStripSeparator tsbSeparator1;
        private ToolStripButton tsbImport;
        private ToolStripButton tsbExport;
        private ToolStripSeparator tsbSeparator2;
        private ToolStripButton tsbExit;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblTotalQuantity;
        private ToolStripStatusLabel lblTotalValue;
        private ToolStripStatusLabel lblSpacer;
        private ToolStripStatusLabel lblClock;
        private GroupBox grpInput;
        private Label lblProductId;
        private TextBox txtProductId;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private GroupBox grpImage;
        private PictureBox picProductImage;
        private Button btnChooseImage;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvProducts;
        private ErrorProvider errProvider;
        private System.Windows.Forms.Timer tmrClock;
        private OpenFileDialog ofdImage;
        private GroupBox grpProductList;
    }
}
