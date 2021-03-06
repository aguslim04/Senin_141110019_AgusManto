﻿using System;
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
    public partial class FormListCustomer : Form
    {
        List list = new List();
        public FormListCustomer()
        {
            InitializeComponent();
            list.fillCustomer(dgvCustomer);
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void refresh()
        {
            list.fillCustomer(dgvCustomer);
        }

        private void FormListCustomer_Load(object sender, EventArgs e)
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
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Apakah anda yakin ingin menghapus ?", "Hapus", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string customer = dgvCustomer.SelectedCells[1].Value.ToString();
                    Delete delete = new Delete();
                    delete.hapusCustomer(customer);
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
