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
    public partial class FormListSupplier : Form
    {
        List list = new List();
        public FormListSupplier()
        {
            InitializeComponent();
            list.fillSupplier(dgvSupplier);
            dgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void refresh()
        {
            list.fillSupplier(dgvSupplier);
        }

        private void FormListSupplier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.SelectedRows.Count > 0)
            {
                string supplier = dgvSupplier.SelectedCells[1].Value.ToString();
                if (MessageBox.Show("Apakah anda yakin ingin menghapus ?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Delete hapus = new Delete();
                    hapus.hapusSupplier(supplier);
                    refresh();
                }
                else
                {
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("Nothing To Delete");
            }
        }
    }
}
