namespace Bai1_QuanLyThietBi
{
    partial class frmDeviceManager
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
            grpInput = new GroupBox();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            txtPrice = new TextBox();
            lblPrice = new Label();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            txtDeviceName = new TextBox();
            lblDeviceName = new Label();
            txtDeviceId = new TextBox();
            lblDeviceId = new Label();
            dgvDevices = new DataGridView();
            errProvider = new ErrorProvider(components);
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            grpDeviceList = new GroupBox();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Controls.Add(numQuantity);
            grpInput.Controls.Add(lblQuantity);
            grpInput.Controls.Add(txtPrice);
            grpInput.Controls.Add(lblPrice);
            grpInput.Controls.Add(cboCategory);
            grpInput.Controls.Add(lblCategory);
            grpInput.Controls.Add(txtDeviceName);
            grpInput.Controls.Add(lblDeviceName);
            grpInput.Controls.Add(txtDeviceId);
            grpInput.Controls.Add(lblDeviceId);
            grpInput.Location = new Point(14, 16);
            grpInput.Margin = new Padding(3, 4, 3, 4);
            grpInput.Name = "grpInput";
            grpInput.Padding = new Padding(3, 4, 3, 4);
            grpInput.Size = new Size(1001, 280);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin thiết bị";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(160, 227);
            numQuantity.Margin = new Padding(3, 4, 3, 4);
            numQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(185, 27);
            numQuantity.TabIndex = 4;
            numQuantity.TextAlign = HorizontalAlignment.Right;
            numQuantity.ThousandsSeparator = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(23, 231);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(98, 20);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Số lượng tồn:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(160, 180);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(352, 27);
            txtPrice.TabIndex = 3;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(23, 184);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(65, 20);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Đơn giá:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(160, 133);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(352, 28);
            cboCategory.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(23, 137);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(91, 20);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Loại thiết bị:";
            // 
            // txtDeviceName
            // 
            txtDeviceName.Location = new Point(160, 87);
            txtDeviceName.Margin = new Padding(3, 4, 3, 4);
            txtDeviceName.MaxLength = 100;
            txtDeviceName.Name = "txtDeviceName";
            txtDeviceName.Size = new Size(352, 27);
            txtDeviceName.TabIndex = 1;
            // 
            // lblDeviceName
            // 
            lblDeviceName.AutoSize = true;
            lblDeviceName.Location = new Point(23, 91);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new Size(86, 20);
            lblDeviceName.TabIndex = 8;
            lblDeviceName.Text = "Tên thiết bị:";
            // 
            // txtDeviceId
            // 
            txtDeviceId.Location = new Point(160, 40);
            txtDeviceId.Margin = new Padding(3, 4, 3, 4);
            txtDeviceId.Name = "txtDeviceId";
            txtDeviceId.ReadOnly = true;
            txtDeviceId.Size = new Size(352, 27);
            txtDeviceId.TabIndex = 99;
            txtDeviceId.TabStop = false;
            // 
            // lblDeviceId
            // 
            lblDeviceId.AutoSize = true;
            lblDeviceId.Location = new Point(23, 44);
            lblDeviceId.Name = "lblDeviceId";
            lblDeviceId.Size = new Size(84, 20);
            lblDeviceId.TabIndex = 100;
            lblDeviceId.Text = "Mã thiết bị:";
            // 
            // dgvDevices
            // 
            dgvDevices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDevices.CausesValidation = false;
            dgvDevices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevices.Location = new Point(37, 409);
            dgvDevices.Margin = new Padding(3, 4, 3, 4);
            dgvDevices.Name = "dgvDevices";
            dgvDevices.RowHeadersWidth = 51;
            dgvDevices.Size = new Size(952, 358);
            dgvDevices.TabIndex = 10;
            // 
            // errProvider
            // 
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errProvider.ContainerControl = this;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(37, 304);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 48);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(504, 304);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(166, 48);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.CausesValidation = false;
            btnDelete.Location = new Point(267, 304);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 48);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.CausesValidation = false;
            btnClear.Location = new Point(756, 304);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(166, 48);
            btnClear.TabIndex = 9;
            btnClear.Text = "Làm mới / Hủy";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // grpDeviceList
            // 
            grpDeviceList.Location = new Point(14, 382);
            grpDeviceList.Name = "grpDeviceList";
            grpDeviceList.Size = new Size(1001, 406);
            grpDeviceList.TabIndex = 11;
            grpDeviceList.TabStop = false;
            grpDeviceList.Text = "Danh sách thiết bị";
            // 
            // frmDeviceManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 800);
            Controls.Add(btnClear);
            Controls.Add(dgvDevices);
            Controls.Add(grpDeviceList);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(grpInput);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmDeviceManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh mục thiết bị điện tử";
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevices).EndInit();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private Label lblDeviceId;
        private TextBox txtDeviceId;
        private Label lblDeviceName;
        private TextBox txtDeviceName;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private DataGridView dgvDevices;
        private ErrorProvider errProvider;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox grpDeviceList;
    }
}
