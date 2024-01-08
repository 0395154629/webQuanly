namespace cau3huynhduyphuong
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.themmoi = new System.Windows.Forms.ToolStripButton();
            this.capnhat = new System.Windows.Forms.ToolStripButton();
            this.xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.timkiemTb = new System.Windows.Forms.ToolStripTextBox();
            this.timkiem = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // themmoi
            // 
            this.themmoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.themmoi.Image = ((System.Drawing.Image)(resources.GetObject("themmoi.Image")));
            this.themmoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.themmoi.Name = "themmoi";
            this.themmoi.Size = new System.Drawing.Size(104, 24);
            this.themmoi.Text = "Thêm mới";
            this.themmoi.Click += new System.EventHandler(this.themmoi_Click);
            // 
            // capnhat
            // 
            this.capnhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.capnhat.Image = ((System.Drawing.Image)(resources.GetObject("capnhat.Image")));
            this.capnhat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(95, 24);
            this.capnhat.Text = "Cập nhật";
            this.capnhat.Click += new System.EventHandler(this.capnhat_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa.Image = ((System.Drawing.Image)(resources.GetObject("xoa.Image")));
            this.xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(60, 24);
            this.xoa.Text = "Xóa";
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 24);
            this.toolStripLabel1.Text = "Tìm";
            // 
            // timkiemTb
            // 
            this.timkiemTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timkiemTb.Name = "timkiemTb";
            this.timkiemTb.Size = new System.Drawing.Size(100, 27);
            // 
            // timkiem
            // 
            this.timkiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.timkiem.Image = ((System.Drawing.Image)(resources.GetObject("timkiem.Image")));
            this.timkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(29, 24);
            this.timkiem.Text = "toolStripButton4";
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themmoi,
            this.capnhat,
            this.xoa,
            this.toolStripLabel1,
            this.timkiemTb,
            this.timkiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Huỳnh Duy Phương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "22-0-20881";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MMH,
            this.MTH,
            this.giaban,
            this.Soluong});
            this.dataGridView1.Location = new System.Drawing.Point(15, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 281);
            this.dataGridView1.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // MMH
            // 
            this.MMH.DataPropertyName = "MMH";
            this.MMH.HeaderText = "Mã Mặt Hàng";
            this.MMH.MinimumWidth = 6;
            this.MMH.Name = "MMH";
            this.MMH.ReadOnly = true;
            this.MMH.Width = 125;
            // 
            // MTH
            // 
            this.MTH.DataPropertyName = "MTH";
            this.MTH.HeaderText = "Tên Mặt Hàng";
            this.MTH.MinimumWidth = 6;
            this.MTH.Name = "MTH";
            this.MTH.ReadOnly = true;
            this.MTH.Width = 125;
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "gia";
            this.giaban.HeaderText = "Giá Bán";
            this.giaban.MinimumWidth = 6;
            this.giaban.Name = "giaban";
            this.giaban.ReadOnly = true;
            this.giaban.Width = 125;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "SL";
            this.Soluong.HeaderText = "SL Tồn Kho";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            this.Soluong.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton themmoi;
        private System.Windows.Forms.ToolStripButton capnhat;
        private System.Windows.Forms.ToolStripButton xoa;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox timkiemTb;
        private System.Windows.Forms.ToolStripButton timkiem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
    }
}

