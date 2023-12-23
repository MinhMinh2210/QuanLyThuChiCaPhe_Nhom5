namespace QuanLyThuChiCaPhe_Nhom5
{
    partial class TonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TonKho));
            this.dgvTonkho = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThanhpham = new DevExpress.XtraEditors.TextEdit();
            this.btnCapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoluong = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhapkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhpham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTonkho
            // 
            this.dgvTonkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTonkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSoluong,
            this.colThoigian,
            this.colThanhpham,
            this.colNhapkho});
            this.dgvTonkho.Location = new System.Drawing.Point(42, 203);
            this.dgvTonkho.Name = "dgvTonkho";
            this.dgvTonkho.RowHeadersWidth = 82;
            this.dgvTonkho.RowTemplate.Height = 33;
            this.dgvTonkho.Size = new System.Drawing.Size(1073, 527);
            this.dgvTonkho.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(629, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý tồn kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(1141, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thành phẩm";
            // 
            // txtThanhpham
            // 
            this.txtThanhpham.Location = new System.Drawing.Point(1357, 272);
            this.txtThanhpham.Name = "txtThanhpham";
            this.txtThanhpham.Size = new System.Drawing.Size(200, 40);
            this.txtThanhpham.TabIndex = 3;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCapnhat.Appearance.Options.UseForeColor = true;
            this.btnCapnhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhat.ImageOptions.Image")));
            this.btnCapnhat.Location = new System.Drawing.Point(1180, 571);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(150, 46);
            this.btnCapnhat.TabIndex = 6;
            this.btnCapnhat.Text = "Cập nhật";
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExcel.Appearance.Options.UseForeColor = true;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1407, 571);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(150, 46);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.Text = "Xuất Excel";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(1301, 656);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(150, 46);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(1357, 197);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(200, 40);
            this.txtSoluong.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(1140, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng tồn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1357, 438);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(313, 31);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1357, 511);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(313, 31);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(1140, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Thời gian tồn kho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(1140, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Thời gian nhập kho";
            // 
            // colSoluong
            // 
            this.colSoluong.HeaderText = "Số lượng tồn";
            this.colSoluong.MinimumWidth = 10;
            this.colSoluong.Name = "colSoluong";
            this.colSoluong.Width = 200;
            // 
            // colThoigian
            // 
            this.colThoigian.HeaderText = "Thời gian tồn";
            this.colThoigian.MinimumWidth = 10;
            this.colThoigian.Name = "colThoigian";
            this.colThoigian.Width = 200;
            // 
            // colThanhpham
            // 
            this.colThanhpham.HeaderText = "Thành phẩm";
            this.colThanhpham.MinimumWidth = 10;
            this.colThanhpham.Name = "colThanhpham";
            this.colThanhpham.Width = 200;
            // 
            // colNhapkho
            // 
            this.colNhapkho.HeaderText = "Thời gian nhập";
            this.colNhapkho.MinimumWidth = 10;
            this.colNhapkho.Name = "colNhapkho";
            this.colNhapkho.Width = 200;
            // 
            // TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 883);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.txtThanhpham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTonkho);
            this.Name = "TonKho";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhpham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTonkho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtThanhpham;
        private DevExpress.XtraEditors.SimpleButton btnCapnhat;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.TextEdit txtSoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoigian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhapkho;
    }
}