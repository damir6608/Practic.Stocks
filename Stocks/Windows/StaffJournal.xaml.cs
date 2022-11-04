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
    /// Interaction logic for StaffJournal.xaml
    /// </summary>
    public partial class StaffJournal : Window
    {
        private readonly EnterpriseStocksEntities _enterpriseStocksEntities = new EnterpriseStocksEntities();
        public StaffJournal()
        {
            InitializeComponent();
            Staffs.ItemsSource = _enterpriseStocksEntities.StaffJournals.Select(x => new { x.Id, x.FirstName, x.MiddleName, x.LastName, x.Position }).ToList();
        }
    }
}
