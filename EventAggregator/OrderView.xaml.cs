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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventAggregator
{
    /// <summary>
    /// Interaction logic for OrderView.xaml
    /// </summary>
    public partial class OrderView : Page, ISubscriber<OrderCreated>, ISubscriber<OrderSaved>
    {
        public OrderView(IEventAggregator ea)
        {
            InitializeComponent();
            ea.Subscribe(this);
        }

        public void OnEvent(OrderCreated e)
        {
            throw new NotImplementedException();
        }

        public void OnEvent(OrderSaved e)
        {
            throw new NotImplementedException();
        }
    }
}
