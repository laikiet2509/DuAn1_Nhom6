using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_NHOM6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1 = new DataGridView();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = tbxTen.Text;
            string quocGia = tbxQuocGia.Text;
            string namThanhLap = tbxNamTL.Text;
            string HLV = tbxHLV.Text;

            DataRow dataRow = dt.NewRow();

            dataRow["Id"] = dt.Rows.Count + 1;
            dataRow["Ten"] = tbxTen.Text;
            dataRow["Quoc gia"] = tbxQuocGia.Text;
            dataRow["Nam Thanh Lap"] = tbxNamTL.Text;
            dataRow["HLV"] = tbxHLV.Text;
            dt.Rows.Add(dataRow);
            dataGridView1.DataSource = dt;
        }
    }
}
