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
    public partial class mausac : Form
    {
        public MauSacServices servicesMS;
        public string idWhenClick;
        public mausac()
        {
            InitializeComponent();
            servicesMS = new MauSacServices();
            LoadGird();
        }
        public void LoadGird()
        {
            dtgView_ms.ColumnCount = 2;
            dtgView_ms.Columns[0].Name = "Mã Kích Cỡ";
            dtgView_ms.Columns[1].Name = "Kích Cỡ";
            dtgView_ms.Rows.Clear();
            foreach (var kc in servicesMS.GetMauSacs())
            {
                dtgView_ms.Rows.Add(kc.MaMauSp, kc.MauSac1);
            }
        }
        public void FillData()
        {
            var sp = servicesMS.GetMauSacs().Find(x => x.MaMauSp.ToString() == idWhenClick);
            if (sp != null)
            {
                txt_mmau.Text = sp.MaMauSp;
                txt_tenmau.Text = sp.MauSac1;
            }
        }

        private void dtgView_ms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= servicesMS.GetMauSacs().Count)
            {
                return;
            }
            idWhenClick = dtgView_ms.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            RegexServices regexServices = new RegexServices();
            if (!regexServices.RegexMaSanPham(txt_mmau.Text))
            {
                MessageBox.Show("Mã màu không hợp lệ, Mời nhập lại");
                return;
            }
            if (!regexServices.RegexChu(txt_tenmau.Text))
            {
                MessageBox.Show("Tên màu không được chứa số, Mời nhập lại");
                return;
            }
            if (servicesMS.GetMauSacs().Any(kc => kc.MaMauSp == txt_mmau.Text))
            {
                MessageBox.Show("Mã màu đã tồn tại, vui lòng nhập mã khác.");
                return;
            }

            // Kiểm tra kích cỡ trùng
            if (servicesMS.GetMauSacs().Any(kc => kc.MauSac1 == txt_tenmau.Text))
            {
                MessageBox.Show("Màu sắc đã tồn tại, vui lòng nhập màu sắc khác.");
                return;
            }
            MauSac kc = new MauSac
            {
                MaMauSp = txt_mmau.Text,
                MauSac1 = txt_tenmau.Text,

            };
            MessageBox.Show(servicesMS.ThemMS(kc));
            LoadGird();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var kc = servicesMS.GetMauSacs().Find(x => x.MaMauSp == idWhenClick);
            if (kc != null)
            {
                RegexServices regexServices = new RegexServices();
                if (!regexServices.RegexMaSanPham(txt_mmau.Text))
                {
                    MessageBox.Show("Mã màu không hợp lệ, Mời nhập lại");
                    return;
                }
                if (!regexServices.RegexChu(txt_tenmau.Text))
                {
                    MessageBox.Show("Tên màu không được chứa số, Mời nhập lại");
                    return;
                }
                // Kiểm tra mã kích cỡ trùng (ngoại trừ chính thực thể đang được sửa)
                if (servicesMS.GetMauSacs().Any(k => k.MaMauSp == txt_mmau.Text && k.MaMauSp != idWhenClick))
                {
                    MessageBox.Show("Mã màu sắc đã tồn tại, vui lòng nhập mã khác.");
                    return;
                }

                // Kiểm tra kích cỡ trùng (ngoại trừ chính thực thể đang được sửa)
                if (servicesMS.GetMauSacs().Any(k => k.MauSac1 == txt_tenmau.Text && k.MaMauSp != idWhenClick))
                {
                    MessageBox.Show("Màu sắc đã tồn tại, vui lòng nhập màu sắc khác.");
                    return;
                }
                kc.MaMauSp = txt_mmau.Text;
                kc.MauSac1 = txt_tenmau.Text;
                MessageBox.Show(servicesMS.SuaMS(kc));
                LoadGird();
            }
        }
    }
}
