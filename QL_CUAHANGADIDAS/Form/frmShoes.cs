using QL_CUAHANGADIDAS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CUAHANGADIDAS
{
    public partial class frmShoes : Form
    {
        BindingSource Shoeslist = new BindingSource();
        public frmShoes()
        {
            InitializeComponent();
            dtgvShoes.DataSource = Shoeslist;
            BindingShoes();
            LoadListShoes();
            Load += frmShoes_Load;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        int currentPageIndex = 1;
        int pageSize = 9;
        int pageNumber = 0;
        int fistRow, lastRow;
        int rows;
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_CUAHANGADIDAS;Integrated Security=True");
        void InsertShoes()
        {
            string name = txbName.Text;
            float price = float.Parse(txbPrice.Text);
            int size = int.Parse(cbSize.Text);
            int count = int.Parse(txbSL.Text);
            DAO.ShoesDAO.Instance.InsertShoes(name,price, count, size);
            
        }
        void UpdateShoes()
        {
            string name = txbName.Text;
            float price = float.Parse(txbPrice.Text);
            int size = int.Parse(cbSize.Text);
            int count = int.Parse(txbSL.Text);
            int id = int.Parse(txbID.Text);
            DAO.ShoesDAO.Instance.UpdatetShoes(name, price, count, size, id);
        }
        void BindingShoes()
        {
            txbID.DataBindings.Add(new Binding("Text", dtgvShoes.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbName.DataBindings.Add(new Binding("Text", dtgvShoes.DataSource, "NAME", true, DataSourceUpdateMode.Never));
            txbSL.DataBindings.Add(new Binding("Text", dtgvShoes.DataSource, "SL", true, DataSourceUpdateMode.Never));
            cbSize.DataBindings.Add(new Binding("Text", dtgvShoes.DataSource, "SIZE", true, DataSourceUpdateMode.Never));
            txbPrice.DataBindings.Add(new Binding("Text", dtgvShoes.DataSource, "PRICE", true, DataSourceUpdateMode.Never));

        }
        void LoadListShoes()
        {
            Shoeslist.DataSource = DAO.ShoesDAO.Instance.GetListShoes();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmShoes_Load(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM TBL_GIAY WHERE ID > 1; ";//Muc dich de lay ra so dong.
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            rows = Convert.ToInt32(cmd.ExecuteScalar());
            pageTotal();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbSL_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnAddShoes_Click(object sender, EventArgs e)
        {
            btnDelShoes.Enabled = false;
            btnUpdateShoes.Enabled = false;
            gbinfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnUpdateShoes_Click(object sender, EventArgs e)
        {
            btnDelShoes.Enabled = false;
            btnAddShoes.Enabled = false;
            gbinfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnDelShoes_Click(object sender, EventArgs e)
        {
            btnUpdateShoes.Enabled = false;
            btnAddShoes.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdateShoes.Enabled = true;
            btnAddShoes.Enabled = true;
            btnDelShoes.Enabled = true;
            gbinfo.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txbName.Text == null || txbName.Text == "")
            {
                MessageBox.Show("Please Enter the name product!");
                return;
            }
            if(txbPrice.Text == null || txbPrice.Text == "")
            {
                MessageBox.Show("Please Enter the price product!");
                return;
            }
            if (txbSL.Text == null || txbSL.Text == "")
            {
                MessageBox.Show("Please Enter the count product!");
                return;
            }
            if (cbSize.Text == null || cbSize.Text == "")
            {
                MessageBox.Show("Please Enter the size product!");
                return;
            }

            if(btnAddShoes.Enabled == true)
            {
                InsertShoes();
                MessageBox.Show("Thêm thành công");
                LoadListShoes();
            }
            if(btnDelShoes.Enabled == true)
            {
                int id = int.Parse(txbID.Text);
                if (MessageBox.Show("Hệ thống sẻ xóa các hoa đơn của Khách hàng này. \n Bạn có muốn xóa? ", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    DAO.ShoesDAO.Instance.DeleteShoess(id);
                    MessageBox.Show("Xóa thành công");
                    LoadListShoes();
                }
                
            }
            if (btnUpdateShoes.Enabled == true)
            {
                UpdateShoes();
                MessageBox.Show("Cập nhật thành công");
                LoadListShoes();
            }
        }

        private void txbSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void txbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dtgvShoes.DataSource = ShoesDAO.Instance.SearchShoesByName(txbSearch.Text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xuất file EXCEL?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DAO.Excel.Instance.export2Excel(dtgvShoes, @"D:\", "ListShoes_ADIDAS");
                MessageBox.Show("Đã xuất file");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pageSize = Convert.ToInt32(numericUpDown1.Value);
            pageTotal();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPageIndex = Convert.ToInt32(comboBox1.Text);
            fistRow = pageSize * (currentPageIndex - 1); //Dòng đầu
            lastRow = pageSize * (currentPageIndex);//Dòng cuối cùng của trang được chọn
            string sql = "select ID, NAME, SIZE,SL, PRICE, Row_number() over(order by ID) STT from TBL_GIAY;"; //Column ITS_REC_VT thường nên chọn là column làm khóa chính
                                                                                  //Có thể dùng Select * hoặc chỉnh định vài column cần thiết để cải thiện tốc độ load dữ liệu. Như vd ở trên của mình là các column: MA_VT,TEN_VT,TEN_VT2

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, fistRow, pageSize, "TBL_GIAY"); //Lấy dữ liệu về từ dòng thứ fistRow và lấy pageSize dòng
            dtgvShoes.DataSource = ds.Tables[0];
        }
        void pageTotal()
        {
            pageNumber = rows % pageSize != 0 ? rows / pageSize + 1 : rows / pageSize; //Tính xem có báo nhiêu trang nếu có pageSize trên trang
            label6.Text = " / " + pageNumber.ToString();
            comboBox1.Items.Clear();
            for (int i = 1; i < pageNumber; i++)
                comboBox1.Items.Add(i + "");
            comboBox1.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
