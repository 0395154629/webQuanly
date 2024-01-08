using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cau3huynhduyphuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void themmoi_Click(object sender, EventArgs e)
        {
            huynhduyphuong_mathang P = new  huynhduyphuong_mathang();
            P.ShowDialog();
            LoadData();
        }
        private void LoadData()
        {
            List<Product> products = Program.products.Values.ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                bool producs = Program.products.ContainsKey(key);
                if (producs)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa ! " + key + " ?", "Xác Nhận ", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        Program.products.Remove(key);
                        LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Không Linh Kiện");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
        }

        private void capnhat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                bool products = Program.products.ContainsKey(key);
                if (products)
                {
                    Product ap = Program.products[key];
                    huynhduyphuong_mathang fa = new huynhduyphuong_mathang();
                    fa.Products = ap;
                    fa.Key = key;
                    fa.ShowDialog();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Linh kiện này không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string search = timkiemTb.Text;
            if (!string.IsNullOrEmpty(search))
            {
                List<Product> searchResults = Program.products.Values
                    .Where(p => p.MTH.ToLower().Contains(search.ToLower()))
                    
                    .ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = searchResults;
            }
            else
            {
                LoadData();
            }
        }
    }
}
