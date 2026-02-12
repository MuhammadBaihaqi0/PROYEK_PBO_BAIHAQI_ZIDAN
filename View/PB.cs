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
    public partial class PB : Form
    {
        string selectedItem = "";
        int selectedHarga = 0;

        public PB()
        {
            InitializeComponent();
        }

        private void SetErrorMessage(TextBox textBox, string message)
        {
            warning.SetError(textBox, message);
        }

        private void PB_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SetErrorMessage(textBox2, "Nomor ID tidak boleh kosong.");
            }
            else
            {
                SetErrorMessage(textBox2, string.Empty);
            }
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
                "Jumlah Cash : 1200\nHarga : Rp 10.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("1200 Cash", 10000);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Cash : 2400\nHarga : Rp 20.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("2400 Cash", 20000);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Cash : 6000\nHarga : Rp 50.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("6000 Cash", 50000);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Cash : 12000\nHarga : Rp 100.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("12000 Cash", 100000);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Cash : 60000\nHarga : Rp 500.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("60000 Cash", 500000);
        }

        private void UpdateSummary(string item, int harga)
        {
            selectedItem = item;
            selectedHarga = harga;

            lblSummaryPlayer.Text = "ID Player : " + textBox2.Text;
            lblSummaryItem.Text = "Item : " + item;
            lblSummaryHarga.Text = "Harga : Rp " + harga.ToString("N0");
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
                ServerId = "-",
                Item = selectedItem,
                Harga = selectedHarga,
                Tanggal = DateTime.Now,
                Status = "Sukses",
                Game = "Point Blank"
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

                // Show History
                FormTransaksi history = new FormTransaksi();
                history.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan transaksi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetForm();
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

    }
}
