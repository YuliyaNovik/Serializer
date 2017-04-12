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
        public MainWindow() {
            InitializeComponent();
        }

        private void ButtonSerialize_Click(object sender, RoutedEventArgs e) {
            List<Debian> list = new List<Debian>();

            list.Add(new Debian("0"));
            list.Add(new Ubuntu("1"));
            list.Add(new LinuxMintDebianEdition("2"));
            list.Add(new SolusOS("3"));
            list.Add(new LinuxMint("4"));
            list.Add(new ElementaryOS("5"));
            list.Add(new CommodoreOS("6"));

            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Debian>), new Type[] { typeof(Debian), typeof(Ubuntu),
                                                        typeof(LinuxMintDebianEdition), typeof(SolusOS), typeof(LinuxMint),
                                                        typeof(ElementaryOS), typeof(CommodoreOS)});
            using (FileStream fStream = new FileStream(@"D:/test.xml", FileMode.Create, FileAccess.Write)) {
                xmlFormat.Serialize(fStream, list);
            }


           
        }

        private void ButtonDeserialize_Click(object sender, RoutedEventArgs e) {
            List<Debian> newList;

            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Debian>), new Type[] { typeof(Debian), typeof(Ubuntu),
                                                        typeof(LinuxMintDebianEdition), typeof(SolusOS), typeof(LinuxMint),
                                                        typeof(ElementaryOS), typeof(CommodoreOS)});

            using (FileStream fStream = new FileStream(@"D:/test.xml", FileMode.Open, FileAccess.Read)) {
                newList = (List<Debian>)xmlFormat.Deserialize(fStream);
            }

        }
    }
}
