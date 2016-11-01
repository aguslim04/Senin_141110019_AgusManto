﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.FlatStyle == FlatStyle.Standard)
            {
                button1.FlatStyle = FlatStyle.Popup;
            }
            else
            {
                button1.FlatStyle = FlatStyle.Standard;
            }

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (button1.FlatStyle == FlatStyle.Popup)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.FlatStyle == FlatStyle.Standard)
            {
                button2.FlatStyle = FlatStyle.Popup;
            }
            else
            {
                button2.FlatStyle = FlatStyle.Standard;
            }

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (button2.FlatStyle == FlatStyle.Popup)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.FlatStyle == FlatStyle.Standard)
            {
                button3.FlatStyle = FlatStyle.Popup;
            }
            else
            {
                button3.FlatStyle = FlatStyle.Standard;
            }

            FontStyle style = richTextBox1.SelectionFont.Style;

            if (button3.FlatStyle == FlatStyle.Popup)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(comboBox1.Text, richTextBox1.Font.Size);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToInt32(comboBox2.SelectedItem), richTextBox1.Font.Style);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("8");
            comboBox2.Items.Add("9");
            comboBox2.Items.Add("10");
            comboBox2.Items.Add("11");
            comboBox2.Items.Add("12");
            comboBox2.Items.Add("14");
            comboBox2.Items.Add("16");
            comboBox2.Items.Add("18");
            comboBox2.Items.Add("20");
            comboBox2.Items.Add("22");
            comboBox2.Items.Add("24");
            comboBox2.Items.Add("26");
            comboBox2.Items.Add("28");
            comboBox2.Items.Add("36");
            comboBox2.Items.Add("48");
            comboBox2.Items.Add("72");
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name.ToString());
            }

            foreach (KnownColor fontcolor in Enum.GetValues(typeof(KnownColor)))
            {
                comboBox3.Items.Add(fontcolor);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 baru = new Form1();
            baru.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog buka = new OpenFileDialog();
            buka.Filter = "Text|*.txt|Document|*.docx|rich Text|*.rtf";
            buka.Title = "Open File";
            buka.FileName = "Choose File";
            buka.ShowDialog();
            if (buka.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(buka.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog simpan = new SaveFileDialog();
            simpan.Filter = "Text|*.txt|Document|*.docx|rich Text|*.rtf";
            simpan.Title = "Save File";
            simpan.ShowDialog();
            if (simpan.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(simpan.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Really Quit ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromName(comboBox3.Text);
        }
    }
}
