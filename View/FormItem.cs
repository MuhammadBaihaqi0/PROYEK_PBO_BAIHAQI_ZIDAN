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
        public FormItem(int idGame, string namaGame)
        {
            InitializeComponent();

            this.idGame = idGame;
            this.namaGame = namaGame;

            // SET MDI CHILD
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        // ================= LOAD FORM =================
        private void FormItem_Load(object sender, EventArgs e)
        {
            lblJudul.Text = "Top Up " + namaGame;
            TampilItem();
        }

        // ================= LOAD ITEM =================
        void TampilItem()
        {
            string query =
                "SELECT nama_item AS Item, harga AS Harga " +
                "FROM items WHERE id_game=" + idGame;

            dgvItem.DataSource = koneksi.ShowData(query);

            dgvItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}