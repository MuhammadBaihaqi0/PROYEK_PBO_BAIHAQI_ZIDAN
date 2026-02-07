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
    public partial class Valorant : Form
    {
        public Valorant()
        {
            InitializeComponent();
        }

        private void SetErrorMessage(TextBox textBox, string message)
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
                SetErrorMessage(textBox2, "Riot ID tidak boleh kosong.");
            }
            else
            {
                SetErrorMessage(textBox2, string.Empty);
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Jumlah Riot : 45,000\nHarga : Rp 45.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Jumlah Riot : 75,000\nHarga : Rp 75.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Jumlah Riot : 149,000\nHarga : Rp 149.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Jumlah Riot : 300,000\nHarga : Rp 300.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Jumlah Riot : 600,000\nHarga : Rp 600.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
