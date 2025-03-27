using MyDictionary.Views.ViDu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary.Views
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            ShowUserControl(new TrangChu());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();  // Xóa nội dung cũ
            uc.Dock = DockStyle.Fill; // Cho UserControl lấp đầy Panel
            panelMain.Controls.Add(uc);  // Thêm UserControl vào Panel
        }

        private void btnChucNang1_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ChucNang1_UserControl());
        }

        private void btnChucNang2_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ChucNang2());
        }

        private void lbLogo_Click(object sender, EventArgs e)
        {
            ShowUserControl(new TrangChu());
        }
    }
}
