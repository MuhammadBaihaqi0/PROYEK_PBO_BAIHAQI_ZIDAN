using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Proyek_besar_pbo_baihaqi_zidan.Controller;
using Proyek_besar_pbo_baihaqi_zidan.Model;

namespace Proyek_besar_pbo_baihaqi_zidan
{
    public partial class FormdiamondML : Form
    {
        string selectedItem = "";
        int selectedHarga = 0;

        public FormdiamondML()
        {
            InitializeComponent();
        }

        private void SetErrorMessage(System.Windows.Forms.TextBox textBox, string message)
        {
            warning.SetError(textBox3, message);
            warning.SetError(textBox4, message);
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

        private bool ValidasiPlayer()
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show(
                    "Silakan masukkan ID Player dan Server ID terlebih dahulu.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false;
            }
            return true;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer())
                return;

            MessageBox.Show("" +
                "Jumlah Diamond : 10\nHarga : Rp 3.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("10 Diamonds", 3000);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer())
                return;

            MessageBox.Show("" +
               "Jumlah Diamond : 50\nHarga : Rp 15.000",
               "Informasi",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            UpdateSummary("50 Diamonds", 15000);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer())
                return;

            MessageBox.Show("" +
               "Jumlah Diamond : 100\nHarga : Rp 30.000",
               "Informasi",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            UpdateSummary("100 Diamonds", 30000);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer())
                return;

            MessageBox.Show("" +
               "Jumlah Diamond : 200\nHarga : Rp 60.000",
               "Informasi",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            UpdateSummary("200 Diamonds", 60000);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer())
                return;

            MessageBox.Show("" +
               "Jumlah Diamond : 1000\nHarga : Rp 300.000",
               "Informasi",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            UpdateSummary("1000 Diamonds", 300000);
        }

        private void FormdiamondML_Load(object sender, EventArgs e)
        {

        }

        private void UpdateSummary(string item, int harga)
        {
            selectedItem = item;
            selectedHarga = harga;

            lblSummaryPlayer.Text = "ID Player : " + textBox3.Text;
            lblSummaryServer.Text = "Server ID : " + textBox4.Text;
            lblSummaryItem.Text = "Item : " + item;
            lblSummaryHarga.Text = "Harga : Rp " + harga.ToString("N0");
        }

        private void ResetForm()
        {
            textBox3.Clear();
            textBox4.Clear();

            lblSummaryPlayer.Text = "ID Player : ";
            lblSummaryServer.Text = "Server ID : ";
            lblSummaryItem.Text = "Item : ";
            lblSummaryHarga.Text = "Harga : ";

            selectedItem = "";
            selectedHarga = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer())
                return;

            if (string.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show(
                    "Silakan pilih item terlebih dahulu.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // JIKA SEMUA VALID
            // SIMPAN TRANSAKSI KE DATABASE
            TransaksiController transController = new TransaksiController();
            TransactionModel transaksi = new TransactionModel
            {
                IdUser = Session.CurrentUser.IdUser, // Dari Session
                IdPlayer = textBox3.Text,
                ServerId = textBox4.Text,
                Item = selectedItem,
                Harga = selectedHarga,
                Tanggal = DateTime.Now,
                Status = "Sukses",
                Game = "Mobile Legends"
            };

            if (transController.AddTransaction(transaksi))
            {
                MessageBox.Show(
                    $"Pembelian berhasil!\n\n" +
                    $"ID Player : {textBox3.Text}\n" +
                    $"Server ID : {textBox4.Text}\n" +
                    $"Item      : {selectedItem}\n" +
                    $"Harga     : Rp {selectedHarga:N0}",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show("Gagal menyimpan transaksi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetForm();
        }
    }
}
