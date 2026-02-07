using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_besar_pbo_baihaqi_zidan.View
{
    public partial class PUBG : Form
    {
        public PUBG()
        {
            InitializeComponent();
        }

        private void setErrorMessage(TextBox textBox, string message)
        {
            warning.SetError(textBox, message);
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                setErrorMessage(textBox2, "Nomor ID tidak boleh kosong.");
            }
            else
            {
                setErrorMessage(textBox2, string.Empty);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Jumlah UC : 10\nHarga : Rp 5.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Jumlah UC : 50\nHarga : Rp 50.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Jumlah UC : 100\nHarga : Rp 100.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Jumlah UC : 200\nHarga : Rp 200.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Jumlah UC : 1000\nHarga : Rp 1000.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
