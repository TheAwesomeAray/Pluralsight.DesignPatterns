using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventAggregator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IEventAggregator _ea;

        private ObservableCollection<Order> _orders;

        public MainWindow()
        {
            InitializeComponent();
            _ea = new SimpleEventAggregator();
        }

        private void AddOrderViews()
        {
            var orderView = new OrderView(_ea);
        }

        public void Create_Click(object sender, RoutedEventArgs e)
        {
            _ea.Publish(new OrderCreated { Order = new Order() });
        }
        
    }
}
