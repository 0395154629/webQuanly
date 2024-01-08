using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cau3huynhduyphuong
{
    public partial class huynhduyphuong_mathang : Form
    {
         private ErrorProvider errorProvider = new ErrorProvider();
        public Product Products { get; set; }
        public int Key { get; set; }
        public huynhduyphuong_mathang()
        {
            InitializeComponent();
        }
        private void KTMMH()
        {
            if (Program.products.Values.Any(p => p.MMH == mamathang.Text.Trim() && p.ID != Key))
            {
                errorProvider.SetError(mamathang, "Mã linh kiện đã tồn tại.");
            }
        }

        private void KTTenMatHang()
        {
            if (string.IsNullOrWhiteSpace(tenmathang.Text))
            {
                errorProvider.SetError(tenmathang, "Vui lòng nhập tên mặt hàng.");
            }
        }
        private void KTGia()
        {
            if (!decimal.TryParse(giaban.Text.Trim(), NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out decimal price) || price <= 0)
            {
                errorProvider.SetError(giaban, "Vui lòng nhập giá bán là số nguyên dương và lớn hơn 0.");
            }
            else
            {
                // Hiển thị giá trị có dấu phân cách nghìn
                giaban.Text = price.ToString("#,##0", CultureInfo.InvariantCulture);
            }
        }
        private void KTSoluongTonKho()
        {
            if (!int.TryParse(soluong.Text.Trim(), NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out int quantity) || quantity <= 0)
            {
                errorProvider.SetError(soluong, "Vui lòng nhập số lượng tồn kho là số nguyên dương và lớn hơn 0.");
            }
            else
            {
                // Hiển thị giá trị có dấu phân cách nghìn
                soluong.Text = quantity.ToString("#,##0", CultureInfo.InvariantCulture);
            }
        }
      
        private void SaveandUp()
        {
            if (Program.products.ContainsKey(Key))
            {
                Products.MMH = mamathang.Text.Trim();
                Products.MTH = tenmathang.Text.Trim();
                Products.gia = giaban.Text.Trim();
                Products.SL = Convert.ToInt32(soluong.Text.Trim());
                Program.products[Key] = Products;
            }
            else
            {
                int ma = Program.products.Count + 1;
                Product product = new Product()
                {
                    ID = Program.products.Count + 1,
                    MMH = mamathang.Text,
                    MTH =tenmathang.Text,
                    gia = giaban.Text.Trim(),
                    SL = Convert.ToInt32(soluong.Text.Trim()),
                   
                };
                Program.products.Add(ma, product);
            }
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            KTMMH();
            KTTenMatHang();
            KTGia();
            KTSoluongTonKho();

            if (errorProvider.GetError(mamathang) == "" && errorProvider.GetError(tenmathang) == "" && errorProvider.GetError(giaban) == "" && errorProvider.GetError(soluong) == "")
            {
                SaveandUp();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void huynhduyphuong_mathang_Load(object sender, EventArgs e)
        {
            if(Products != null)
            {
                mamathang.Text = Products.MMH;
                tenmathang.Text = Products.MTH;
                giaban.Text = Products.gia + "";
                soluong.Text = Products.SL + "";
                
            }
        }
    }
}
