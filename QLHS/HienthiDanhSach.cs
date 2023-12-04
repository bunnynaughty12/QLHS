using System;
using System.Windows.Forms;

namespace QLHS
{
    public partial class fHienThiDanhSach : Form
    {
        private BOHocSinh boHocSinh;

        public fHienThiDanhSach()
        {
            InitializeComponent();
            boHocSinh = new BOHocSinh();
            Load += fHienThiDanhSach_Load; // Thêm sự kiện Load vào constructor
        }

        private void fHienThiDanhSach_Load(object sender, EventArgs e)
        {
            // Gọi hàm để hiển thị danh sách học sinh khi form được load
            HienThiDanhSachHocSinh();

        }

        private void HienThiDanhSachHocSinh()
        {
            try
            {
                // Gọi phương thức từ BO để lấy danh sách học sinh từ cơ sở dữ liệu
                dtgvDanhSachHS.DataSource = boHocSinh.LayDSHocSinh();

                // Optional: Cấu hình hiển thị cho DataGridView, ví dụ: tự động điều chỉnh cột
                dtgvDanhSachHS.AutoResizeColumns();
                dtgvDanhSachHS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Đã xảy ra lỗi khi hiển thị danh sách học sinh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fThongtinHocSinh f = new fThongtinHocSinh();
            this.Hide();
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn không
                if (dtgvDanhSachHS.SelectedRows.Count > 0)
                {
                    // Lấy giá trị của cột Mahs (mã học sinh) từ dòng được chọn
                    string maHS = dtgvDanhSachHS.SelectedRows[0].Cells["Mahs"].Value.ToString();

                    // Gọi phương thức Delete từ BO để xóa học sinh theo mã
                    boHocSinh.Delete(maHS);

                    // Hiển thị lại danh sách học sinh sau khi xóa
                    HienThiDanhSachHocSinh();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Đã xảy ra lỗi khi xóa học sinh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
