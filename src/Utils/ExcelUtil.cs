using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Utils
{
  internal class ExcelUtil
  {
    public static void Export(DataGridView dgv, string sheetName)
    {
      if (dgv.Rows.Count == 0)
      {
        MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog
        {
          Filter = "Excel Files|*.xlsx",
          Title = "Save Excel File",
          FileName = $"{sheetName}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
          using (var workbook = new XLWorkbook())
          {
            var worksheet = workbook.Worksheets.Add(sheetName);

            // Export headers
            int colIndex = 1;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
              if (!column.Visible) continue;
              worksheet.Cell(1, colIndex).SetValue(column.HeaderText);
              colIndex++;
            }

            // Export data
            int rowIndex = 2;
            foreach (DataGridViewRow row in dgv.Rows)
            {
              if (row.IsNewRow) continue;

              colIndex = 1;
              foreach (DataGridViewColumn column in dgv.Columns)
              {
                if (!column.Visible) continue;

                var value = row.Cells[column.Index].Value;
                var cell = worksheet.Cell(rowIndex, colIndex);

                if (value == null || value == DBNull.Value)
                {
                  cell.SetValue(string.Empty);
                }
                else if (value is decimal decimalValue)
                {
                  cell.SetValue(decimalValue);
                }
                else if (value is double doubleValue)
                {
                  cell.SetValue(doubleValue);
                }
                else if (value is float floatValue)
                {
                  cell.SetValue(floatValue);
                }
                else if (value is DateTime dateValue)
                {
                  cell.SetValue(dateValue);
                }
                else
                {
                  cell.SetValue(value.ToString());
                }

                // Format tương tự DataTable
                if (value is decimal || value is double || value is float)
                {
                  cell.Style.NumberFormat.Format = "#,##0";
                  cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                }
                else if (value is DateTime)
                {
                  cell.Style.NumberFormat.Format = "dd/MM/yyyy";
                  cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                }
                else
                {
                  cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                }

                colIndex++;
              }
              rowIndex++;
            }

            // Format header và data như bạn đã có
            var headerRange = worksheet.Range(1, 1, 1, dgv.Columns.GetColumnCount(DataGridViewElementStates.Visible));
            headerRange.Style.Font.Bold = true;
            headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
            headerRange.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
            headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            headerRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            var dataRange = worksheet.Range(1, 1, dgv.Rows.Count + 1, dgv.Columns.GetColumnCount(DataGridViewElementStates.Visible));
            dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
            dataRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            worksheet.Columns().AdjustToContents();

            workbook.SaveAs(saveFileDialog.FileName);
            MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Có lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }


  }
}
