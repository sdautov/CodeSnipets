using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // 
        var data = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string> { { "Name", "Alice" }, { "Age", "30" } },
            new Dictionary<string, string> { { "Name", "Bob" }, { "Age", "25" } }
        };

        // 
        var filePath = "output.xlsx";

        // 
        using (var package = new ExcelPackage())
        {
            // 
            var worksheet = package.Workbook.Worksheets.Add("Sheet1");

            // 
            int row = 1;
            foreach (var key in data[0].Keys)
            {
                worksheet.Cells[row, 1].Value = key;
                row++;
            }

            //
            int column = 1;
            foreach (var dict in data)
            {
                row = 2; // 
                foreach (var value in dict.Values)
                {
                    worksheet.Cells[row, column].Value = value;
                    row++;
                }
                column++;
            }

            // 
            FileInfo file = new FileInfo(filePath);
            package.SaveAs(file);
        }
    }
}
