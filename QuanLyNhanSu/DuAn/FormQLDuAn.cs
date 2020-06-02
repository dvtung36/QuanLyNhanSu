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

namespace QuanLyNhanSu.DuAn
{
    public partial class FormQLDuAn : Form
    {
        MyDBcontext db = new MyDBcontext();
        public FormQLDuAn()
        {
            InitializeComponent();
        }

        private void FormQLDuAn_Load(object sender, EventArgs e)
        {
            List<DU_AN> DsDA = db.DU_AN.ToList();
            foreach (DU_AN tn in DsDA)
            {
                ListViewItem item = new ListViewItem(tn.MA_DA.ToString());
                item.SubItems.Add(tn.TEN_DA.ToString());
                item.SubItems.Add(tn.DIA_DIEM.ToString());
                item.SubItems.Add(tn.MA_PB.ToString());
                listDsDA.Items.Add(item);
            }
        }

        private void listDsDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDsDA.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = listDsDA.SelectedItems[0];
                txtMaDA.Text = itemSelected.SubItems[0].Text;
                txtTenDA.Text = itemSelected.SubItems[1].Text;
                txtĐiaiem.Text = itemSelected.SubItems[2].Text;
                txtMaPB.Text = itemSelected.SubItems[3].Text;

            }
        }
    }
}
