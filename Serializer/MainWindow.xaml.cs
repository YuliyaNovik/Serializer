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
using Serializer.Distributions;
using System.Xml.Serialization;
using System.IO;

namespace Serializer {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        List<Debian> list;

        public MainWindow() {
            InitializeComponent();
            this.list = new List<Debian>();
        }

        private void ButtonSerialize_Click(object sender, RoutedEventArgs e) {
        
        }

        private void ButtonDeserialize_Click(object sender, RoutedEventArgs e) {
        
        }
    }
}
