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

namespace Proyek_besar_pbo_baihaqi_zidan.View
{
    public partial class Roblox : Form
    {
        string selectedItem = "";
        int selectedHarga = 0;

        public Roblox()
        {
            InitializeComponent();
        }

        private void SetErrorMessage(System.Windows.Forms.TextBox textBox, string message)
        {
            warning.SetError(textBox, message);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SetErrorMessage(textBox2, "Email tidak boleh kosong.");
            }
            else
            {
                SetErrorMessage(textBox2, string.Empty);
            }
        }

        private void Roblox_Load(object sender, EventArgs e)
        {

        }

        private bool ValidasiPlayer()
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show(
                    "Silakan masukkan Email terlebih dahulu.",
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
                "Jumlah Gift : 45,000\nHarga : Rp 45.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("Gift 45,000", 45000);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Gift : 75,000\nHarga : Rp 75.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("Gift 75,000", 75000);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Gift : 149,000\nHarga : Rp 149.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("Gift 149,000", 149000);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Gift : 300,000\nHarga : Rp 300.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("Gift 300,000", 300000);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Gift : 600,000\nHarga : Rp 600.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("Gift 600,000", 600000);
        }

        private void UpdateSummary(string item, int harga)
        {
            selectedItem = item;
            selectedHarga = harga;

            lblSummaryPlayer.Text = "Email : " + textBox2.Text;
            lblSummaryItem.Text = "Item : " + item;
            lblSummaryHarga.Text = "Harga : Rp " + harga.ToString("N0");
        }

        private void ResetForm()
        {
            textBox2.Clear();

            lblSummaryPlayer.Text = "Email : ";
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
                ServerId = "-",
                Item = selectedItem,
                Harga = selectedHarga,
                Tanggal = DateTime.Now,
                Status = "Sukses",
                Game = "Roblox"
            };

            if (transController.AddTransaction(transaksi))
            {
                MessageBox.Show(
                    $"Pembelian berhasil!\n\n" +
                    $"Email : {textBox2.Text}\n" +
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
