using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Stocks.Windows
{
    /// <summary>
    /// Interaction logic for InventoryTypeJournal.xaml
    /// </summary>
    public partial class InventoryTypeJournal : Window
    {
        private readonly EnterpriseStocksEntities _enterpriseStocksEntities = new EnterpriseStocksEntities();
        public InventoryTypeJournal()
        {
            InitializeComponent();
            Refreshing();
        }

        private void InventoryTypes_Selected(object sender, RoutedEventArgs e)
        {
            var b = InventoryTypes.SelectedItem;
            try
            {
                var deletedObj = _enterpriseStocksEntities.InventoryTypeJournals.ToList().Find(w => w.Id.ToString() == b?.ToString()[0].ToString());
                if (deletedObj != null)
                    new AddInventoryType(deletedObj).Show();
            }
            catch (Exception)
            {
                InventoryTypes.UnselectAll();
            }
        }

        private void Refreshing()
        {
            InventoryTypes.UnselectAll();
            InventoryTypes.ItemsSource = new EnterpriseStocksEntities().InventoryTypeJournals.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            new AddInventoryType().Show();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            Refreshing();
        }

        private void ExportPDF_Click(object sender, RoutedEventArgs e)
        {
            //Task.Run(() => //async runtume - anti screen lock
            //{
            //    List<Services> allServices;
            //    using (SecondISRPOLabaEntities usersEntities = new SecondISRPOLabaEntities())
            //    {
            //        allServices = usersEntities.Services.ToList()
            //            .OrderBy(s => s.name)
            //            .ToList();
            //    }

            //    #region convenient grouping structure
            //    var costsCategories = allServices
            //            .OrderBy(o => o.cost)
            //            .GroupBy(s => s.cost)
            //            .ToDictionary(g => g.Key, g => g.Select(s => new { s.id, s.name, s.type, s.cost })
            //            .ToArray());
            //    #endregion

            //    var app = new Microsoft.Office.Interop.Word.Application();
            //    Microsoft.Office.Interop.Word.Document document = app.Documents.Add();


            //    for (int i = 0; i < _sheetsCount; i++)
            //    {
            //        #region spliting by condition
            //        var data = i == 0 ? costsCategories.Where(w => w.Key.HasValue && w.Key.Value >= 0 && w.Key.Value <= 350)
            //            : i == 1 ? costsCategories.Where(w => w.Key.HasValue && w.Key.Value >= 250 && w.Key.Value <= 800)
            //            : i == 2 ? costsCategories.Where(w => w.Key.HasValue && w.Key.Value >= 800) : costsCategories;
            //        Microsoft.Office.Interop.Word.Paragraph paragraph = document.Paragraphs.Add();
            //        Microsoft.Office.Interop.Word.Range range = paragraph.Range;
            //        range.Text = $"Категория {i + 1}";
            //        paragraph.set_Style("Заголовок 1");
            //        range.InsertParagraphAfter();
            //        var tableParagraph = document.Paragraphs.Add();
            //        var tableRange = tableParagraph.Range;
            //        var studentsTable =
            //        document.Tables.Add(tableRange, data.Select(s => s.Value.Length).Sum() + 1, 4);
            //        studentsTable.Borders.InsideLineStyle =
            //        studentsTable.Borders.OutsideLineStyle =
            //        Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
            //        studentsTable.Range.Cells.VerticalAlignment =
            //        Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            //        Microsoft.Office.Interop.Word.Range cellRange;
            //        cellRange = studentsTable.Cell(1, 1).Range;
            //        cellRange.Text = "Id";
            //        cellRange = studentsTable.Cell(1, 2).Range;
            //        cellRange.Text = "Название услуги";
            //        cellRange = studentsTable.Cell(1, 3).Range;
            //        cellRange.Text = "Вид услуги";
            //        cellRange = studentsTable.Cell(1, 4).Range;
            //        cellRange.Text = "Стоимость";
            //        studentsTable.Rows[1].Range.Bold = 1;
            //        studentsTable.Rows[1].Range.ParagraphFormat.Alignment =
            //        Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            //        int row = 1;
            //        var stepSize = 1;
            //        foreach (var group in data)
            //        {
            //            #endregion

            //            foreach (var currentCost in group.Value)
            //            {
            //                cellRange = studentsTable.Cell(row + stepSize, 1).Range;
            //                cellRange.Text = currentCost.id.ToString();
            //                cellRange.ParagraphFormat.Alignment =
            //                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

            //                cellRange = studentsTable.Cell(row + stepSize, 2).Range;
            //                cellRange.Text = currentCost.name;
            //                cellRange.ParagraphFormat.Alignment =
            //                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

            //                cellRange = studentsTable.Cell(row + stepSize, 3).Range;
            //                cellRange.Text = currentCost.type;
            //                cellRange.ParagraphFormat.Alignment =
            //                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;

            //                cellRange = studentsTable.Cell(row + stepSize, 4).Range;
            //                cellRange.Text = currentCost.cost.ToString();
            //                cellRange.ParagraphFormat.Alignment =
            //                Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            //                row++;
            //            }
            //        }
            //        Microsoft.Office.Interop.Word.Paragraph countCostsParagraph = document.Paragraphs.Add();
            //        Microsoft.Office.Interop.Word.Range countCostsRange = countCostsParagraph.Range;
            //        countCostsRange.Text = $"Данных в группировке - { data.Select(s => s.Value.Length).Sum()} ";
            //        countCostsRange.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorDarkRed;
            //        countCostsRange.InsertParagraphAfter();
            //        document.Words.Last.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdSectionBreakNextPage);
            //    }
            //    app.Visible = true;
            //    document.SaveAs2(@"D:\outputFileWord.docx");
            //    document.SaveAs2(@"D:\outputFilePdf.pdf",
            //    Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
            //});
        }
    }
}
