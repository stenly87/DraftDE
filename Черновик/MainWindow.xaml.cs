using System;
using System.Collections.Generic;
using System.IO;
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
using Черновик.View;

namespace Черновик
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MainWindow instance;

        public MainWindow()
        {
            InitializeComponent();
            instance = this;
            Navigate(new MaterialListView());
        }

        public static void Navigate(Page page) => 
            instance.MainFrame.Navigate(page);
    }
}
