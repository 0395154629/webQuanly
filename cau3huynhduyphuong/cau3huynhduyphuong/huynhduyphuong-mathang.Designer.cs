namespace cau3huynhduyphuong
{
    partial class huynhduyphuong_mathang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Lưu = new System.Windows.Forms.Button();
            this.mamathang = new System.Windows.Forms.TextBox();
            this.tenmathang = new System.Windows.Forms.TextBox();
            this.giaban = new System.Windows.Forms.TextBox();
            this.soluong = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Mặt Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Mặt Hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi Chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "SLTồn Kho:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đóng ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Lưu
            // 
            this.Lưu.Location = new System.Drawing.Point(165, 374);
            this.Lưu.Name = "Lưu";
            this.Lưu.Size = new System.Drawing.Size(75, 23);
            this.Lưu.TabIndex = 5;
            this.Lưu.Text = "Lưu";
            this.Lưu.UseVisualStyleBackColor = true;
            this.Lưu.Click += new System.EventHandler(this.Lưu_Click);
            // 
            // mamathang
            // 
            this.mamathang.Location = new System.Drawing.Point(200, 87);
            this.mamathang.Name = "mamathang";
            this.mamathang.Size = new System.Drawing.Size(100, 22);
            this.mamathang.TabIndex = 6;
            // 
            // tenmathang
            // 
            this.tenmathang.Location = new System.Drawing.Point(200, 128);
            this.tenmathang.Name = "tenmathang";
            this.tenmathang.Size = new System.Drawing.Size(100, 22);
            this.tenmathang.TabIndex = 7;
            // 
            // giaban
            // 
            this.giaban.Location = new System.Drawing.Point(200, 165);
            this.giaban.Name = "giaban";
            this.giaban.Size = new System.Drawing.Size(100, 22);
            this.giaban.TabIndex = 8;
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(200, 212);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(100, 22);
            this.soluong.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(165, 240);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(342, 96);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // huynhduyphuong_mathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.giaban);
            this.Controls.Add(this.tenmathang);
            this.Controls.Add(this.mamathang);
            this.Controls.Add(this.Lưu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "huynhduyphuong_mathang";
            this.Text = "huynhduyphuong_mathang";
            this.Load += new System.EventHandler(this.huynhduyphuong_mathang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Lưu;
        private System.Windows.Forms.TextBox mamathang;
        private System.Windows.Forms.TextBox tenmathang;
        private System.Windows.Forms.TextBox giaban;
        private System.Windows.Forms.TextBox soluong;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}