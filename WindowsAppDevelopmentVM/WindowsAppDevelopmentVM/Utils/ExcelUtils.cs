using System.Data;
using System.IO;
using OfficeOpenXml;

namespace WindowsAppDevelopmentVM.Utils
{
    public class ExcelUtils
    {
        public static void saveToExcel(DataTable dataTable, string filePath)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");
                worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                FileInfo file = new FileInfo(filePath);
                package.SaveAs(file);
            }
        }

        public static DataTable readExcelToDataTable(string filePath)
        {
            var dt = new DataTable();
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int colCount = worksheet.Dimension.End.Column;
                int rowCount = worksheet.Dimension.End.Row;

                for (int col = 1; col <= colCount; col++)
                    dt.Columns.Add(worksheet.Cells[1, col].Text);

                for (int row = 2; row <= rowCount; row++)
                {
                    var dataRow = dt.NewRow();
                    for (int col = 1; col <= colCount; col++)
                        dataRow[col - 1] = worksheet.Cells[row, col].Text;

                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }
    }
}