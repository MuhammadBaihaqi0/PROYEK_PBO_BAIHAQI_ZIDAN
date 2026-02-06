using Proyek_besar_pbo_baihaqi_zidan.Controller;
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
    public partial class FormItem : Form
    {
        Koneksi koneksi = new Koneksi();
        int idGame;
        string namaGame;

        // ================= CONSTRUCTOR =================
        public FormItem(int id_game, string nama_game)
        {
            InitializeComponent();

            idGame = id_game;
            namaGame = nama_game;

            // SET SEBAGAI CHILD MDI
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        // ================= LOAD FORM =================
        private void FormItem_Load(object sender, EventArgs e)
        {
            lblJudul.Text = "Top Up " + namaGame;
            LoadItem();
        }

        // ================= LOAD ITEM =================
        void LoadItem()
        {
            flowItem.Controls.Clear();

            DataTable dt = koneksi.ShowData(
                "SELECT * FROM items WHERE id_game=" + idGame
            );

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Item belum tersedia untuk game ini",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                Panel card = new Panel();
                card.Width = 180;
                card.Height = 130;
                card.BackColor = Color.FromArgb(40, 40, 60);
                card.Margin = new Padding(15);

                // ===== Nama Item =====
                Label lblNama = new Label();
                lblNama.Text = row["nama_item"].ToString();
                lblNama.ForeColor = Color.White;
                lblNama.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblNama.Location = new Point(10, 10);
                lblNama.AutoSize = true;

                // ===== Harga =====
                Label lblHarga = new Label();
                lblHarga.Text = "Rp " + row["harga"].ToString();
                lblHarga.ForeColor = Color.Gold;
                lblHarga.Location = new Point(10, 40);
                lblHarga.AutoSize = true;

                // ===== Tombol Beli =====
                Button btnBeli = new Button();
                btnBeli.Text = "BELI";
                btnBeli.Width = 150;
                btnBeli.Height = 35;
                btnBeli.Location = new Point(10, 75);
                btnBeli.BackColor = Color.MediumPurple;
                btnBeli.ForeColor = Color.White;

                string namaItem = row["nama_item"].ToString();
                string harga = row["harga"].ToString();

                btnBeli.Click += (s, e) =>
                {
                    // VALIDASI ID PLAYER & SERVER
                    if (tbUserID.Text == "" || tbZonaID.Text == "")
                    {
                        MessageBox.Show(
                            "ID Player dan Server ID wajib diisi!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }

                    // KONFIRMASI PEMBELIAN
                    MessageBox.Show(
                        "Game : " + namaGame +
                        "\nID Player : " + tbUserID.Text +
                        "\nServer ID : " + tbZonaID.Text +
                        "\nItem : " + row["nama_item"] +
                        "\nHarga : Rp " + row["harga"],
                        "Konfirmasi Pembelian",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                };

                card.Controls.Add(lblNama);
                card.Controls.Add(lblHarga);
                card.Controls.Add(btnBeli);

                flowItem.Controls.Add(card);
            }
        }

        private void flowItem_Paint(object sender, PaintEventArgs e)
        {
            // Tidak perlu isi
        }
    }
}