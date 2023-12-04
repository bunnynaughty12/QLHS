using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class fThongtinHocSinh : Form
    {
        public fThongtinHocSinh()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            fHienThiDanhSach f = new fHienThiDanhSach();
            this.Hide();
            f.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các điều khiển nhập liệu
                string maHS = txbMaHS.Text;
                string tenHS = txbTenHS.Text;
                DateTime ngaySinh = dtpkNgaySinh.Value;
                string diaChi = txbDiaChi.Text;
                string lop = cbLop.Text;
                float diemTB = float.Parse(txbDiemTB.Text);

                // Tạo một đối tượng HocSinhInfo để lưu thông tin học sinh mới
                HocSinhInfo hsInfo = new HocSinhInfo
                {
                    Mahs = maHS,
                    Hoten = tenHS,
                    Ngaysinh = ngaySinh,
                    Diachi = diaChi,
                    Lophoc = new LopInfo { Malop = lop }, // Gán thông tin lớp học
                    Diemtb = diemTB
                };

                // Gọi phương thức Insert từ BO để thêm học sinh mới vào cơ sở dữ liệu
                BOHocSinh bohs = new BOHocSinh();
                bohs.Insert(hsInfo);


            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Đã xảy ra lỗi khi thêm học sinh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fThongtinHocSinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHOCSINHDataSet1.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter1.Fill(this.qLHOCSINHDataSet1.LOP);
            // TODO: This line of code loads data into the 'qLHOCSINHDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLHOCSINHDataSet.LOP);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOPTableAdapter.FillBy(this.qLHOCSINHDataSet.LOP);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOPTableAdapter.FillBy1(this.qLHOCSINHDataSet.LOP);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOPTableAdapter.FillBy2(this.qLHOCSINHDataSet.LOP);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOPTableAdapter.FillBy3(this.qLHOCSINHDataSet.LOP);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOPTableAdapter.FillBy4(this.qLHOCSINHDataSet.LOP);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy5ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lOPTableAdapter.FillBy5(this.qLHOCSINHDataSet.LOP);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
