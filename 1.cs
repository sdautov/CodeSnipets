using Telerik.Windows.Documents.Spreadsheet.Model;
using Telerik.Windows.Documents.Spreadsheet.SpreadsheetCommands;

public void ExportToExcel(List<Dictionary<string, object>> data)
{
    var workbook = new Workbook();
    var worksheet = workbook.Worksheets.Add();

    // 
    var headers = data.First().Keys.ToList();
    for (int i = 0; i < headers.Count; i++)
    {
        worksheet.Cells[0, i].SetValue(headers[i]);
    }

    // 
    for (int rowIndex = 0; rowIndex < data.Count; rowIndex++)
    {
        var row = data[rowIndex];
        for (int colIndex = 0; colIndex < headers.Count; colIndex++)
        {
            worksheet.Cells[rowIndex + 1, colIndex].SetValue(row[headers[colIndex]]);
        }
    }

    //
    var saveFileDialog = new SaveFileDialog
    {
        Filter = "Excel Files|*.xlsx"
    };
    if (saveFileDialog.ShowDialog() == true)
    {
        using (var stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
        {
            workbook.Save(stream);
        }
    }
}
