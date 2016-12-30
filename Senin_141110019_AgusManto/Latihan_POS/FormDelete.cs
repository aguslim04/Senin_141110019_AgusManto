using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Latihan_POS.Class;

namespace Latihan_POS
{
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {
            cmbType.Items.Add("Barang");
            cmbType.Items.Add("Customer");
            cmbType.Items.Add("Supplier");
            cmbType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cariKode = txtKodeHapus.Text;
            string nama = cmbType.SelectedItem.ToString();
            Status stats = new Status();
            bool hasil = stats.cekKode(cariKode, nama);
            if(cmbType.SelectedIndex == 0)
            {
                if(cariKode.Trim() !="" && hasil)
                {

                    if (MessageBox.Show("Apakah anda yakin ingin menghapus ?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Delete delete = new Delete();
                        delete.hapusBarang(cariKode);
                        MessageBox.Show("Hapus Data barang Sukses");
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            if (cmbType.SelectedIndex == 1)
            {
                if (cariKode.Trim() != "" && hasil)
                {

                    if (MessageBox.Show("Apakah anda yakin ingin menghapus ?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Delete delete = new Delete();
                        delete.hapusCustomer(cariKode);
                        MessageBox.Show("Hapus Data Customer Sukses");
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            if (cmbType.SelectedIndex == 2)
            {
                if (cariKode.Trim() != "" && hasil)
                {

                    if (MessageBox.Show("Apakah anda yakin ingin menghapus ?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Delete delete = new Delete();
                        delete.hapusSupplier(cariKode);
                        MessageBox.Show("Hapus Data Supplier Sukses");
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }
    }
}
