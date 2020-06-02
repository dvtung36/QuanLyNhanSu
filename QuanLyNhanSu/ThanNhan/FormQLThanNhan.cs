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

namespace QuanLyNhanSu.ThanNhan
{
    public partial class FormQLThanNhan : Form
    {
        MyDBcontext db = new MyDBcontext();
        public FormQLThanNhan()
        {
            InitializeComponent();
        }

        private void FormQLThanNhan_Load(object sender, EventArgs e)
        {
            List<THAN_NHAN> DsTN = db.THAN_NHAN.ToList();
            foreach (THAN_NHAN tn in DsTN)
            {
                ListViewItem item = new ListViewItem(tn.MA_NV.ToString());
                item.SubItems.Add(tn.TEN_TN.ToString());
                item.SubItems.Add(tn.NGAY_SINH.ToString());
                item.SubItems.Add(tn.QUAN_HE.ToString());
                listDsTN.Items.Add(item);
            }
            

        }

        private void listDsTN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDsTN.SelectedItems.Count > 0)
            {
                ListViewItem itemSelected = listDsTN.SelectedItems[0];
                cbMaNV.Text = itemSelected.SubItems[0].Text;
                txtHoTen.Text = itemSelected.SubItems[1].Text;
                dateTimePicker1.Text = itemSelected.SubItems[2].Text;
                 txtQuanHe.Text = itemSelected.SubItems[3].Text;
  
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                THAN_NHAN tn = new THAN_NHAN()
                {
                    MA_NV = cbMaNV.Text,
                    TEN_TN = txtHoTen.Text,
                    NGAY_SINH = dateTimePicker1.Value,
                    QUAN_HE = txtQuanHe.Text,
                  
                };
                db.THAN_NHAN.Add(tn);
                db.SaveChanges();
                MessageBox.Show("them thanh cong");
                FormQLThanNhan_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Them That bai. Chi tiet loi: " + ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                THAN_NHAN nv = db.THAN_NHAN.Find(cbMaNV.Text.ToString());
                nv.TEN_TN = txtHoTen.Text;
                nv.NGAY_SINH = dateTimePicker1.Value;
                nv.QUAN_HE = txtQuanHe.Text;
                db.SaveChanges();
                MessageBox.Show("Sua thanh cong");

                List<THAN_NHAN> DsNV = db.THAN_NHAN.ToList();

                foreach (THAN_NHAN n in DsNV)
                {
                    ListViewItem item = new ListViewItem(nv.MA_NV.ToString());
                    item.SubItems.Add(n.TEN_TN.ToString());
                    item.SubItems.Add(n.NGAY_SINH.ToString());
                    item.SubItems.Add(n.QUAN_HE.ToString());
                 
                    listDsTN.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                THAN_NHAN nv = db.THAN_NHAN.Find(cbMaNV.Text.ToString());
                db.THAN_NHAN.Remove(nv);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                FormQLThanNhan_Load(sender, e);
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex.Message); }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            f.Show();
            this.Hide();
        }
    }
} 