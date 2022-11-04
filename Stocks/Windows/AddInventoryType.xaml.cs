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
    /// Interaction logic for AddInventoryType.xaml
    /// </summary>
    public partial class AddInventoryType : Window
    {
        private readonly EnterpriseStocksEntities _enterpriseStocksEntities;
        public AddInventoryType()
        {
            _enterpriseStocksEntities = new EnterpriseStocksEntities();
            InitializeComponent();
        }
        public AddInventoryType(Stocks.InventoryTypeJournal inventoryTypeJournal)
        {
            _enterpriseStocksEntities = new EnterpriseStocksEntities();
            InitializeComponent();
            Id.Content = inventoryTypeJournal.Id;
            Name.Text = inventoryTypeJournal.Name;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Name.Text))
            {
                var deletedObj = _enterpriseStocksEntities.InventoryTypeJournals.ToList().Find(w => w.Id.ToString() == (Id?.Content != null ? Id?.Content.ToString() : ""));
                if (deletedObj != null)
                {
                    var up = _enterpriseStocksEntities.InventoryTypeJournals.SingleOrDefault(x => x.Id == deletedObj.Id);
                    up.Name = Name.Text;
                    _enterpriseStocksEntities.SaveChanges();
                }
                else
                {
                    _enterpriseStocksEntities.InventoryTypeJournals.Add(new Stocks.InventoryTypeJournal() { Name = Name.Text });
                    _enterpriseStocksEntities.SaveChanges();
                }
                this.Close();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var res = MessageBox.Show("Вы действительно хотите удлаить запись?", "Удаление", MessageBoxButton.YesNo);
            if (res == MessageBoxResult.Yes)
            {
                var deletedObj = _enterpriseStocksEntities.InventoryTypeJournals.ToList().Find(w => w.Id.ToString() == Id.Content.ToString());
                _enterpriseStocksEntities.InventoryTypeJournals.Remove(deletedObj);
                _enterpriseStocksEntities.SaveChanges();
                this.Close();
            }
        }
    }
}
