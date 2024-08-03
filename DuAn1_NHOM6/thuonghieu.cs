using BUS.Services;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class thuonghieu : Form
    {
        public ThuongHieuServices servicesTH;
        public string idWhenClick;
        public thuonghieu()
        {
            InitializeComponent();
            servicesTH = new ThuongHieuServices();
            LoadGird();
        }
        public void LoadGird()
        {
            dtgView_TH.ColumnCount = 2;
            dtgView_TH.Columns[0].Name = "Mã Kích Cỡ";
            dtgView_TH.Columns[1].Name = "Kích Cỡ";
            dtgView_TH.Rows.Clear();
            foreach (var kc in servicesTH.GetThuongHieus())
            {
                dtgView_TH.Rows.Add(kc.MaThuongHieu, kc.TenThuongHieu);
            }
        }
        public void FillData()
        {
            var sp = servicesTH.GetThuongHieus().Find(x => x.MaThuongHieu.ToString() == idWhenClick);
            if (sp != null)
            {
                txt_mthuonghieu.Text = sp.MaThuongHieu;
                txt_tenthuonghieu.Text = sp.TenThuongHieu;
            }
        }

        private void dtgView_TH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= servicesTH.GetThuongHieus().Count)
            {
                return;
            }
            idWhenClick = dtgView_TH.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            RegexServices regexServices = new RegexServices();

            ThuongHieu kc = new ThuongHieu
            {
                MaThuongHieu = txt_mthuonghieu.Text,
                TenThuongHieu = txt_tenthuonghieu.Text,

            };
            MessageBox.Show(servicesTH.ThemTH(kc));
            LoadGird();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var kc = servicesTH.GetThuongHieus().Find(x => x.MaThuongHieu == idWhenClick);
            if (kc != null)
            {
                RegexServices regexServices = new RegexServices();

                kc.MaThuongHieu = txt_mthuonghieu.Text;
                kc.TenThuongHieu = txt_tenthuonghieu.Text;
                MessageBox.Show(servicesTH.SuaTH(kc));
                LoadGird();
            }
        }
    }
}
