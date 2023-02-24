using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace cau.federico._4h.threads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _counter = 0;
        const int NGIRI = 1500;
        object obj = new object();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(incrementa);
            t.Start();
        }

        void incrementa()
        {
            for(int x = 0; x<NGIRI; x++)
            {
                lock (obj) { _counter++; }
                Dispatcher.Invoke((() => { txtCounter1.Text = _counter.ToString(); }));
               
                Thread.Sleep(1);
                
            }
        }
    }
}
