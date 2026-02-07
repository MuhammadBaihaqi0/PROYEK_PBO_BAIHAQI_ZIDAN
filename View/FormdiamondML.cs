using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_besar_pbo_baihaqi_zidan
{
    public partial class FormdiamondML : Form
    {
        public FormdiamondML()
        {
            InitializeComponent();
        }

        private void SetErrorMessage(TextBox textBox, string message)
        {
            warning.SetError(textBox, message);
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
    }
}
