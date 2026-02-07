using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyek_besar_pbo_baihaqi_zidan.lib
{
    public class Excel
    {
        public void ExportToExcel(DataGridView dgv, string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("Data User");

                // HEADER
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1].Value = dgv.Columns[i].HeaderText;
                }

                // DATA
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1].Value = dgv.Rows[i].Cells[j].Value;
                    }
                }

                File.WriteAllBytes(filePath, package.GetAsByteArray());
            }
        }
    }
}
