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
            
        }
    }
}
