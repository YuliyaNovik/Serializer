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
        List<dynamic> list;
        List<dynamic> listComboBox;

        public MainWindow() {
            InitializeComponent();
            this.list = new List<dynamic>();
            this.listComboBox = new List<dynamic>();
            this.listBox.ItemsSource = this.list;
            InitListComboBox();
        }

        private void InitListComboBox() {
            this.listComboBox.Add(new Debian());
            this.listComboBox.Add(new Ubuntu());
            this.listComboBox.Add(new LinuxMint());
            this.listComboBox.Add(new LinuxMintDebianEdition());
            this.listComboBox.Add(new ElementaryOS());
            this.listComboBox.Add(new SolusOS());
            this.listComboBox.Add(new CommodoreOS());
        }

        private void ButtonSerialize_Click(object sender, RoutedEventArgs e) {
            Serializer.XmlSerializer.Serialize(list, @"D:/test.xml");
        }

        private void ButtonDeserialize_Click(object sender, RoutedEventArgs e) {
            // this.list = Serializer.XmlSerializer.Deserialize(@"D:/test.xml");
            foreach (var item in Serializer.XmlSerializer.Deserialize(@"D:/test.xml")) {
                this.list.Add(item);
            }
            UpdateList();
        }

        private void SetupField(Debian debian) {
            this.systemName.IsEnabled = true;
            this.systemVersion.IsEnabled = true;
            this.coreVersion.IsEnabled = true;
            this.imageName.IsEnabled = false;
            this.namingRules.IsEnabled = false;
            this.fileManager.IsEnabled = false;
            this.installer.IsEnabled = false;
            this.specialDesign.IsEnabled = false;
        }

        private void SetupField(Ubuntu ubuntu) {
            this.systemName.IsEnabled = true;
            this.systemVersion.IsEnabled = true;
            this.coreVersion.IsEnabled = true;
            this.imageName.IsEnabled = true;
            this.namingRules.IsEnabled = true;
            this.fileManager.IsEnabled = false;
            this.installer.IsEnabled = false;
            this.specialDesign.IsEnabled = false;

        }

        private void SetupField(LinuxMint linuxMint) {
            this.systemName.IsEnabled = true;
            this.systemVersion.IsEnabled = true;
            this.coreVersion.IsEnabled = true;
            this.imageName.IsEnabled = true;
            this.namingRules.IsEnabled = true;
            this.fileManager.IsEnabled = true;
            this.installer.IsEnabled = false;
            this.specialDesign.IsEnabled = false;

        }

        private void SetupField(LinuxMintDebianEdition linuxMintDebianEdition) {
            this.systemName.IsEnabled = true;
            this.systemVersion.IsEnabled = true;
            this.coreVersion.IsEnabled = true;
            this.imageName.IsEnabled = false;
            this.namingRules.IsEnabled = false;
            this.fileManager.IsEnabled = true;
            this.installer.IsEnabled = false;
            this.specialDesign.IsEnabled = false;
        }

        private void SetupField(ElementaryOS elementaryOS) {
            this.systemName.IsEnabled = true;
            this.systemVersion.IsEnabled = true;
            this.coreVersion.IsEnabled = true;
            this.imageName.IsEnabled = true;
            this.namingRules.IsEnabled = true;
            this.fileManager.IsEnabled = false;
            this.installer.IsEnabled = true;
            this.specialDesign.IsEnabled = false;
        }

        private void SetupField(SolusOS solusOS) {
            this.systemName.IsEnabled = true;
            this.systemVersion.IsEnabled = true;
            this.coreVersion.IsEnabled = true;
            this.imageName.IsEnabled = false;
            this.namingRules.IsEnabled = false;
            this.fileManager.IsEnabled = true;
            this.installer.IsEnabled = true;
            this.specialDesign.IsEnabled = false;
        }

        private void SetupField(CommodoreOS commodorreOS) {
            this.systemName.IsEnabled = true;
            this.systemVersion.IsEnabled = true;
            this.coreVersion.IsEnabled = true;
            this.imageName.IsEnabled = true;
            this.namingRules.IsEnabled = true;
            this.fileManager.IsEnabled = true;
            this.installer.IsEnabled = false;
            this.specialDesign.IsEnabled = true;
        }


        private void AddToList(Debian debian) {
            string systemName = this.systemName.Text;
            string systemVersion = this.systemVersion.Text;
            string systemCore = this.coreVersion.Text;
            this.list.Add(new Debian(systemName, systemVersion, systemCore));
        }
        
        private void AddToList(Ubuntu ubuntu) {
            string systemName = this.systemName.Text;
            string systemVersion = this.systemVersion.Text;
            string systemCore = this.coreVersion.Text;
            string imageName = this.imageName.Text;
            string namingRules = this.namingRules.Text;
            this.list.Add(new Ubuntu(systemName, systemVersion, systemCore, imageName, namingRules));
        }
        private void AddToList(LinuxMint linuxMint) {
            string systemName = this.systemName.Text;
            string systemVersion = this.systemVersion.Text;
            string systemCore = this.coreVersion.Text;
            string imageName = this.imageName.Text;
            string namingRules = this.namingRules.Text;
            string fileManager = this.fileManager.Text;
            this.list.Add(new LinuxMint(systemName, systemVersion, systemCore, imageName, namingRules, fileManager));
        }
        private void AddToList(LinuxMintDebianEdition linuxMintDebianEDition) {
            string systemName = this.systemName.Text;
            string systemVersion = this.systemVersion.Text;
            string systemCore = this.coreVersion.Text;
            string fileManager = this.fileManager.Text;
            this.list.Add(new LinuxMintDebianEdition(systemName, systemVersion, systemCore, fileManager));
        }
        private void AddToList(ElementaryOS elementaryOS) {
            string systemName = this.systemName.Text;
            string systemVersion = this.systemVersion.Text;
            string systemCore = this.coreVersion.Text;
            string imageName = this.imageName.Text;
            string namingRules = this.namingRules.Text;
            string fileManager = this.fileManager.Text;
            this.list.Add(new ElementaryOS(systemName, systemVersion, systemCore, imageName, namingRules, fileManager));
        }
        private void AddToList(SolusOS solusOS) {
            string systemName = this.systemName.Text;
            string systemVersion = this.systemVersion.Text;
            string systemCore = this.coreVersion.Text;
            string fileManager = this.fileManager.Text;
            string installer = this.installer.Text;
            this.list.Add(new SolusOS(systemName, systemVersion, systemCore, fileManager, installer));
        }
        private void AddToList(CommodoreOS commodoreOS) {
            string systemName = this.systemName.Text;
            string systemVersion = this.systemVersion.Text;
            string systemCore = this.coreVersion.Text;
            string imageName = this.imageName.Text;
            string namingRules = this.namingRules.Text;
            string fileManager = this.fileManager.Text;
            string specialDesign = this.specialDesign.Text;
            this.list.Add(new CommodoreOS(systemName, systemVersion, systemCore, imageName, namingRules, fileManager, specialDesign));
        }
    
        private void ViewProperties(Debian debian) {
            this.SetupField(debian);
            this.systemName.Text = debian.systemName;
            this.systemVersion.Text = debian.systemVersion;
            this.coreVersion.Text = debian.coreVersion;
        }

        private void ViewProperties(Ubuntu ubuntu) {
            this.SetupField(ubuntu);
            this.systemName.Text = ubuntu.systemName;
            this.systemVersion.Text = ubuntu.systemVersion;
            this.coreVersion.Text = ubuntu.coreVersion;
            this.imageName.Text = ubuntu.imageName;
            this.namingRules.Text = ubuntu.namingRules;
        }
        private void ViewProperties(LinuxMint linuxMint) {
            this.SetupField(linuxMint);
            this.systemName.Text = linuxMint.systemName;
            this.systemVersion.Text = linuxMint.systemVersion;
            this.coreVersion.Text = linuxMint.coreVersion;
            this.imageName.Text = linuxMint.imageName;
            this.namingRules.Text = linuxMint.namingRules;
            this.fileManager.Text = linuxMint.fileManager;
        }
        private void ViewProperties(LinuxMintDebianEdition linuxMintDebianEdition) {
            this.SetupField(linuxMintDebianEdition);
            this.systemName.Text = linuxMintDebianEdition.systemName;
            this.systemVersion.Text = linuxMintDebianEdition.systemVersion;
            this.coreVersion.Text = linuxMintDebianEdition.coreVersion;
            this.fileManager.Text = linuxMintDebianEdition.fileManager;
        }
        private void ViewProperties(ElementaryOS elementaryOS) {
            this.SetupField(elementaryOS);
            this.systemName.Text = elementaryOS.systemName;
            this.systemVersion.Text = elementaryOS.systemVersion;
            this.coreVersion.Text = elementaryOS.coreVersion;
            this.imageName.Text = elementaryOS.imageName;
            this.namingRules.Text = elementaryOS.namingRules;
            this.installer.Text = elementaryOS.installer;
        }
        private void ViewProperties(SolusOS solusOS) {
            this.SetupField(solusOS);
            this.systemName.Text = solusOS.systemName;
            this.systemVersion.Text = solusOS.systemVersion;
            this.coreVersion.Text = solusOS.coreVersion;
            this.fileManager.Text = solusOS.fileManager;
            this.installer.Text = solusOS.installer;
        }
        private void ViewProperties(CommodoreOS commodoreOS) {
            this.SetupField(commodoreOS);
            this.systemName.Text = commodoreOS.systemName;
            this.systemVersion.Text = commodoreOS.systemVersion;
            this.coreVersion.Text = commodoreOS.coreVersion;
            this.imageName.Text = commodoreOS.imageName;
            this.namingRules.Text = commodoreOS.namingRules;
            this.fileManager.Text = commodoreOS.fileManager;
            this.specialDesign.Text = commodoreOS.specialDesign;
        }

        private void EditProperties(Debian debian) {
            this.list[this.list.IndexOf(debian)].systemName = this.systemName.Text;
            this.list[this.list.IndexOf(debian)].systemVersion = this.systemVersion.Text;
            this.list[this.list.IndexOf(debian)].coreVersion = this.coreVersion.Text;
        }

        private void EditProperties(Ubuntu ubuntu) {
            this.list[this.list.IndexOf(ubuntu)].systemName = this.systemName.Text;
            this.list[this.list.IndexOf(ubuntu)].systemVersion = this.systemVersion.Text;
            this.list[this.list.IndexOf(ubuntu)].systemCore = this.coreVersion.Text;
            this.list[this.list.IndexOf(ubuntu)].imageName = this.imageName.Text;
            this.list[this.list.IndexOf(ubuntu)].namingRules = this.namingRules.Text;
        }
        private void EditProperties(LinuxMint linuxMint) {
            this.list[this.list.IndexOf(linuxMint)].systemName = this.systemName.Text;
            this.list[this.list.IndexOf(linuxMint)].systemVersion = this.systemVersion.Text;
            this.list[this.list.IndexOf(linuxMint)].systemCore = this.coreVersion.Text;
            this.list[this.list.IndexOf(linuxMint)].imageName = this.imageName.Text;
            this.list[this.list.IndexOf(linuxMint)].namingRules = this.namingRules.Text;
            this.list[this.list.IndexOf(linuxMint)].fileManager = this.fileManager.Text;
        }
        private void EditProperties(LinuxMintDebianEdition linuxMintDebianEdition) {
            this.list[this.list.IndexOf(linuxMintDebianEdition)].systemName = this.systemName.Text;
            this.list[this.list.IndexOf(linuxMintDebianEdition)].systemVersion = this.systemVersion.Text;
            this.list[this.list.IndexOf(linuxMintDebianEdition)].coreVersion = this.coreVersion.Text;
            this.list[this.list.IndexOf(linuxMintDebianEdition)].fileManager = this.fileManager.Text;
        }

        private void EditProperties(ElementaryOS elementaryOS) {
            this.list[this.list.IndexOf(elementaryOS)].systemName = this.systemName.Text;
            this.list[this.list.IndexOf(elementaryOS)].systemVersion = this.systemVersion.Text;
            this.list[this.list.IndexOf(elementaryOS)].systemCore = this.coreVersion.Text;
            this.list[this.list.IndexOf(elementaryOS)].imageName = this.imageName.Text;
            this.list[this.list.IndexOf(elementaryOS)].namingRules = this.namingRules.Text;
            this.list[this.list.IndexOf(elementaryOS)].installer = this.installer.Text;
        }
        private void EditProperties(SolusOS solusOS) {
            this.list[this.list.IndexOf(solusOS)].systemName = this.systemName.Text;
            this.list[this.list.IndexOf(solusOS)].systemVersion = this.systemVersion.Text;
            this.list[this.list.IndexOf(solusOS)].coreVersion = this.coreVersion.Text;
            this.list[this.list.IndexOf(solusOS)].fileManager = this.fileManager.Text;
            this.list[this.list.IndexOf(solusOS)].installer = this.installer.Text;
        }
        private void EditProperties(CommodoreOS commodoreOS) {
            this.list[this.list.IndexOf(commodoreOS)].systemName = this.systemName.Text;
            this.list[this.list.IndexOf(commodoreOS)].systemVersion = this.systemVersion.Text;
            this.list[this.list.IndexOf(commodoreOS)].systemCore = this.coreVersion.Text;
            this.list[this.list.IndexOf(commodoreOS)].imageName = this.imageName.Text;
            this.list[this.list.IndexOf(commodoreOS)].namingRules = this.namingRules.Text;
            this.list[this.list.IndexOf(commodoreOS)].fileManager = this.fileManager.Text;
            this.list[this.list.IndexOf(commodoreOS)].specialDesign = this.specialDesign.Text;
        }
        private void UpdateList() {
            this.listBox.ItemsSource = null;
            this.listBox.ItemsSource = this.list;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e) {
            this.AddToList(this.listComboBox[this.comboBox.SelectedIndex]);
            UpdateList();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e) {
            if (this.listBox.SelectedIndex < this.list.Count && this.listBox.SelectedIndex >= 0) {
                this.EditProperties(this.list[this.listBox.SelectedIndex]);
            }
            UpdateList();
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e) {
            if (this.listBox.SelectedIndex < this.list.Count && this.listBox.SelectedIndex >= 0) {
                this.list.RemoveAt(this.listBox.SelectedIndex);
            }
            UpdateList();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (this.listBox.SelectedIndex < this.list.Count && this.listBox.SelectedIndex >= 0) {
                this.ViewProperties(this.list[this.listBox.SelectedIndex]);
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            this.SetupField(this.listComboBox[this.comboBox.SelectedIndex]);
        }
    }
}
