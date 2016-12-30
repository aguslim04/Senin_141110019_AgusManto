using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrasiBarang barang = new FormRegistrasiBarang();
            barang.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrasiCustomer customer = new FormRegistrasiCustomer();
            customer.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistrasiSupplier supplier = new FormRegistrasiSupplier();
            supplier.Show();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListBarang lstBarang = new FormListBarang();
            lstBarang.Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListCustomer lstCustomer = new FormListCustomer();
            lstCustomer.Show();
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormListSupplier lstSupplier = new FormListSupplier();
            lstSupplier.Show();
        }

        private void editListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEdit edit = new FormEdit();
            edit.Show();
        }

        private void deleteListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDelete delete = new FormDelete();
            delete.Show();
        }

        private void jualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPenjualan jual = new FormPenjualan();
            jual.Show();
        }

        private void beliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPembelian beli = new FormPembelian();
            beli.Show();
        }
    }
}
