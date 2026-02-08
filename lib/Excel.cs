using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Proyek_besar_pbo_baihaqi_zidan.lib
{
    public class Excel
    {
        public static void Export(DataGridView dgv, string filePath)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("Data User");

                // HEADER
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1].Value = dgv.Columns[i].HeaderText;
                    ws.Cells[1, i + 1].Style.Font.Bold = true;
                }

                // DATA
                for (int r = 0; r < dgv.Rows.Count; r++)
                {
                    if (dgv.Rows[r].IsNewRow) continue;

                    for (int c = 0; c < dgv.Columns.Count; c++)
                    {
                        ws.Cells[r + 2, c + 1].Value =
                            dgv.Rows[r].Cells[c].Value?.ToString();
                    }
                }

                ws.Cells.AutoFitColumns();

                FileInfo fi = new FileInfo(filePath);
                package.SaveAs(fi);
            }
        }
    }
}
