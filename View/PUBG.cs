using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyek_besar_pbo_baihaqi_zidan.Controller;
using Proyek_besar_pbo_baihaqi_zidan.Model;

namespace Proyek_besar_pbo_baihaqi_zidan.View
{
    public partial class PUBG : Form
    {
        string selectedItem = "";
        int selectedHarga = 0;

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

        private bool ValidasiPlayer()
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show(
                    "Silakan masukkan ID Player terlebih dahulu.",
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
            if (!ValidasiPlayer()) return;
            MessageBox.Show("" +
                "Jumlah UC : 10\nHarga : Rp 5.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("10 UC", 5000);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah UC : 50\nHarga : Rp 50.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("50 UC", 50000);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah UC : 100\nHarga : Rp 100.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("100 UC", 100000);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah UC : 200\nHarga : Rp 200.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("200 UC", 200000);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah UC : 1000\nHarga : Rp 1000.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("1000 UC", 1000000);
        }

        private void PUBG_Load(object sender, EventArgs e)
        {

        }

        private void UpdateSummary(string item, int harga)
        {
            selectedItem = item;
            selectedHarga = harga;

            lblSummaryPlayer.Text = "ID Player : " + textBox2.Text;
            lblSummaryItem.Text = "Item : " + item;
            lblSummaryHarga.Text = "Harga : Rp " + harga.ToString("N0");
        }

        private void ResetForm()
        {
            textBox2.Clear();

            lblSummaryPlayer.Text = "ID Player : ";
            lblSummaryItem.Text = "Item : ";
            lblSummaryHarga.Text = "Harga : ";

            selectedItem = "";
            selectedHarga = 0;
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
                IdUser = Session.CurrentUser.IdUser,
                IdPlayer = textBox2.Text,
                ServerId = "-", // PUBG Mobile usually uses ID only or ID+Name but form only has one text box
                Item = selectedItem,
                Harga = selectedHarga,
                Tanggal = DateTime.Now,
                Status = "Sukses",
                Game = "PUBG Mobile"
            };

            if (transController.AddTransaction(transaksi))
            {
                MessageBox.Show(
                    $"Pembelian berhasil!\n\n" +
                    $"ID Player : {textBox2.Text}\n" +
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
