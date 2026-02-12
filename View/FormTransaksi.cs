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
    public partial class FormTransaksi : Form
    {
        TransaksiController transController = new TransaksiController();
        private DataGridView dgvTransaksi;

        public FormTransaksi()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Setup DataGridView manually since we are editing code
            this.dgvTransaksi = new DataGridView();
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(12, 12);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.Size = new System.Drawing.Size(776, 380); // Reduced height to make room for button
            this.dgvTransaksi.TabIndex = 0;
            this.dgvTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaksi.AllowUserToAddRows = false;
            this.dgvTransaksi.AllowUserToDeleteRows = false;
            this.dgvTransaksi.ReadOnly = true;
            this.Controls.Add(this.dgvTransaksi);

            // Add Back Button
            Button btnBack = new Button();
            btnBack.Text = "Kembali ke Top Up";
            btnBack.Location = new System.Drawing.Point(12, 400);
            btnBack.Size = new System.Drawing.Size(150, 40);
            btnBack.Click += (s, e) => { this.Close(); };
            this.Controls.Add(btnBack);

            this.Load += new System.EventHandler(this.FormTransaksi_Load);
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("Session expired. Please login again.");
                this.Close();
                return;
            }

            DataTable dt;

            if (Session.CurrentUser.Role == "Admin")
            {
                dt = transController.GetAllTransactions();
            }
            else
            {
                dt = transController.GetTransactionsByUser(Session.CurrentUser.IdUser);
            }

            dgvTransaksi.DataSource = dt;
        }
    }
}
