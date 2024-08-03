﻿using BUS.Services;
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
    public partial class kichco : Form
    {
        public KichCoServices servicesKC;
        public string idWhenClick;
        public kichco()
        {
            InitializeComponent();
            servicesKC = new KichCoServices();
            LoadGird();
        }
        public void LoadGird()
        {
            dtgView_kco.ColumnCount = 2;
            dtgView_kco.Columns[0].Name = "Mã Kích Cỡ";
            dtgView_kco.Columns[1].Name = "Kích Cỡ";
            dtgView_kco.Rows.Clear();
            foreach (var kc in servicesKC.GetKichCos())
            {
                dtgView_kco.Rows.Add(kc.MaKichCoSp, kc.KichCo1);
            }
        }
        public void FillData()
        {
            var sp = servicesKC.GetKichCos().Find(x => x.MaKichCoSp.ToString() == idWhenClick);
            if (sp != null)
            {
                txt_makco.Text = sp.MaKichCoSp;
                txt_kco.Text = sp.KichCo1;
            }
        }

        private void dtgView_kco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0 || rowIndex >= servicesKC.GetKichCos().Count)
            {
                return;
            }
            idWhenClick = dtgView_kco.Rows[rowIndex].Cells[0].Value.ToString();
            FillData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            RegexServices regexServices = new RegexServices();

            KichCo kc = new KichCo
            {
                MaKichCoSp = txt_makco.Text,
                KichCo1 = txt_kco.Text,
                
            };
            MessageBox.Show(servicesKC.ThemKC(kc));
            LoadGird();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var kc = servicesKC.GetKichCos().Find(x => x.MaKichCoSp == idWhenClick);
            if (kc != null)
            {
                RegexServices regexServices = new RegexServices();
                
                kc.MaKichCoSp = txt_makco.Text;
                kc.KichCo1 = txt_kco.Text;    
                MessageBox.Show(servicesKC.SuaKC(kc));
                LoadGird();
            }
        }
    }
}
