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
    public partial class Valorant : Form
    {
        string selectedItem = "";
        int selectedHarga = 0;

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

        private void panel2_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Riot : 45,000\nHarga : Rp 45.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("45,000 Riot", 45000);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Riot : 75,000\nHarga : Rp 75.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("75,000 Riot", 75000);
        }

        private void panel4_Click(object sender, EventArgs e)
        {

            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Riot : 149,000\nHarga : Rp 149.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("149,000 Riot", 149000);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {

            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Riot : 300,000\nHarga : Rp 300.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("300,000 Riot", 300000);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (!ValidasiPlayer()) return;

            MessageBox.Show("" +
                "Jumlah Riot : 600,000\nHarga : Rp 600.000",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            UpdateSummary("600,000 Riot", 600000);
        }

        private void Valorant_Load(object sender, EventArgs e)
        {

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
                Game = "Valorant"
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
