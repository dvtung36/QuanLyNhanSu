using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.model;
using QuanLyNhanSu.ThanNhan;
using QuanLyNhanSu.DuAn;

namespace QuanLyNhanSu
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnQLThanNhan_Click(object sender, EventArgs e)
        {
            FormQLThanNhan f = new FormQLThanNhan();
            f.Show();
            this.Hide();
        }

        private void btnQLDA_Click(object sender, EventArgs e)
        {
            FormQLDuAn f = new FormQLDuAn();
            f.Show();
            this.Hide();
        }

        private void btnQLPB_Click(object sender, EventArgs e)
        {

        }
    }
}
