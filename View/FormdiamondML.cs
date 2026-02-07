using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_besar_pbo_baihaqi_zidan
{
    public partial class FormdiamondML : Form
    {
        public FormdiamondML()
        {
            InitializeComponent();
        }

        private void SetErrorMessage(TextBox textBox, string message)
        {
            warning.SetError(textBox, message);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                SetErrorMessage(textBox3, "Nomor ID tidak boleh kosong.");
            }
            else
            {
                SetErrorMessage(textBox3, string.Empty);
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                SetErrorMessage(textBox4, "Jumlah diamond tidak boleh kosong.");
            }
            else
            {
                SetErrorMessage(textBox4, string.Empty);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Jumlah Diamond : 10\nHarga : Rp 3.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
               "Jumlah Diamond : 50\nHarga : Rp 15.000",
               "Informasi",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
               "Jumlah Diamond : 100\nHarga : Rp 30.000",
               "Informasi",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
               "Jumlah Diamond : 200\nHarga : Rp 60.000",
               "Informasi",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
               "Jumlah Diamond : 1000\nHarga : Rp 300.000",
               "Informasi",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }
    }
}
