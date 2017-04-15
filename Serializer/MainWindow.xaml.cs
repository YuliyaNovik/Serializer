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

        private void BoolSetupField(bool imageName, bool namingRules, bool fileManager, bool installer, bool specialDesign) {
            this.imageName.IsEnabled = imageName;
            this.namingRules.IsEnabled = namingRules;
            this.fileManager.IsEnabled = fileManager;
            this.installer.IsEnabled = installer;
            this.specialDesign.IsEnabled = specialDesign;
        }

        private void SetupField(Debian debian) {
            BoolSetupField(false, false, false, false, false);
        }

        private void SetupField(Ubuntu ubuntu) {
            BoolSetupField(true, true, false, false, false);

        }

        private void SetupField(LinuxMint linuxMint) {
            BoolSetupField(true, true, true, false, false);

        }

        private void SetupField(LinuxMintDebianEdition linuxMintDebianEdition) {
            BoolSetupField(false, false, true, false, false);
        }

        private void SetupField(ElementaryOS elementaryOS) {
            BoolSetupField(true, true, false, true, false);
        }

        private void SetupField(SolusOS solusOS) {
            BoolSetupField(false, false, true, true, false);
        }

        private void SetupField(CommodoreOS commodorreOS) {
            BoolSetupField(true, true, true, false, true);
        }


        private void AddToList(Debian debian) {
            this.list.Add(new Debian(this.systemName.Text, this.systemVersion.Text, this.coreVersion.Text));
        }
        
        private void AddToList(Ubuntu ubuntu) {
            this.list.Add(new Ubuntu(this.systemName.Text, this.systemVersion.Text, this.coreVersion.Text,
                                     this.imageName.Text, this.namingRules.Text));
        }
        private void AddToList(LinuxMint linuxMint) {
            this.list.Add(new LinuxMint(this.systemName.Text, this.systemVersion.Text, this.coreVersion.Text,
                                        this.imageName.Text, this.namingRules.Text, this.fileManager.Text));
        }
        private void AddToList(LinuxMintDebianEdition linuxMintDebianEDition) {
            this.list.Add(new LinuxMintDebianEdition(this.systemName.Text, this.systemVersion.Text,
                                                     this.coreVersion.Text, this.fileManager.Text));
        }
        private void AddToList(ElementaryOS elementaryOS) {
            this.list.Add(new ElementaryOS(this.systemName.Text, this.systemVersion.Text, this.coreVersion.Text,
                                           this.imageName.Text, this.namingRules.Text, this.fileManager.Text));
        }
        private void AddToList(SolusOS solusOS) {
            this.list.Add(new SolusOS(this.systemName.Text, this.systemVersion.Text, this.coreVersion.Text,
                                      this.fileManager.Text, this.installer.Text));
        }
        private void AddToList(CommodoreOS commodoreOS) {
            this.list.Add(new CommodoreOS(this.systemName.Text, this.systemVersion.Text, this.coreVersion.Text,
                                          this.imageName.Text, this.namingRules.Text, this.fileManager.Text,
                                           this.specialDesign.Text));
        }

        private void SetupRequiredValues(string systemName = "", string systemVersion = "", string coreVersion = "", string imageName = "", string namingRules = "", string fileManager = "", string installer = "", string specialDesign = "") {
            this.systemName.Text = systemName;
            this.systemVersion.Text = systemVersion;
            this.coreVersion.Text = coreVersion;
            this.imageName.Text = imageName;
            this.namingRules.Text = namingRules;
            this.fileManager.Text = fileManager;
            this.specialDesign.Text = specialDesign;
            this.installer.Text = installer;
        }

        private void ViewProperties(Debian debian) {
            this.SetupField(debian);
            this.SetupRequiredValues(systemName: debian.systemName, systemVersion: debian.systemVersion,
                                     coreVersion: debian.coreVersion);
        }

        private void ViewProperties(Ubuntu ubuntu) {
            this.SetupField(ubuntu);
            this.SetupRequiredValues(systemName: ubuntu.systemName, systemVersion: ubuntu.systemVersion,
                                     coreVersion: ubuntu.coreVersion, imageName: ubuntu.imageName,
                                     namingRules: ubuntu.namingRules);
        }

        private void ViewProperties(LinuxMint linuxMint) {
            this.SetupField(linuxMint);
            this.SetupRequiredValues(systemName: linuxMint.systemName, systemVersion: linuxMint.systemVersion,
                                     coreVersion: linuxMint.coreVersion, imageName: linuxMint.imageName,
                                     namingRules: linuxMint.namingRules, fileManager: linuxMint.fileManager);
        }

        private void ViewProperties(LinuxMintDebianEdition linuxMintDebianEdition) {
            this.SetupField(linuxMintDebianEdition);
            this.SetupRequiredValues(systemName: linuxMintDebianEdition.systemName, systemVersion: linuxMintDebianEdition.systemVersion,
                                     coreVersion: linuxMintDebianEdition.coreVersion, fileManager: linuxMintDebianEdition.fileManager);
        }

        private void ViewProperties(ElementaryOS elementaryOS) {
            this.SetupField(elementaryOS);
            this.SetupRequiredValues(systemName: elementaryOS.systemName, systemVersion: elementaryOS.systemVersion,
                                     coreVersion: elementaryOS.coreVersion, imageName: elementaryOS.imageName,
                                     namingRules: elementaryOS.namingRules, installer: elementaryOS.installer);
        }

        private void ViewProperties(SolusOS solusOS) {
            this.SetupField(solusOS);
            this.SetupRequiredValues(systemName: solusOS.systemName, systemVersion: solusOS.systemVersion,
                                     coreVersion: solusOS.coreVersion,fileManager: solusOS.fileManager,
                                      installer: solusOS.installer);
        }
        private void ViewProperties(CommodoreOS commodoreOS) {
            this.SetupField(commodoreOS);
            this.SetupRequiredValues(systemName: commodoreOS.systemName, systemVersion: commodoreOS.systemVersion,
                                     coreVersion: commodoreOS.coreVersion, imageName: commodoreOS.imageName,
                                     namingRules: commodoreOS.namingRules, fileManager: commodoreOS.fileManager,
                                     specialDesign: commodoreOS.specialDesign);
        }

        private void EditRequiredProperties(Debian debian) {
            this.list[this.list.IndexOf(debian)].systemName = this.systemName.Text;
            this.list[this.list.IndexOf(debian)].systemVersion = this.systemVersion.Text;
            this.list[this.list.IndexOf(debian)].coreVersion = this.coreVersion.Text;
        }

        private void EditProperties(Debian debian) {
            EditRequiredProperties(debian);
        }

        private void EditProperties(Ubuntu ubuntu) {
            EditRequiredProperties(ubuntu);
            this.list[this.list.IndexOf(ubuntu)].imageName = this.imageName.Text;
            this.list[this.list.IndexOf(ubuntu)].namingRules = this.namingRules.Text;
        }
        private void EditProperties(LinuxMint linuxMint) {
            EditRequiredProperties(linuxMint);
            this.list[this.list.IndexOf(linuxMint)].imageName = this.imageName.Text;
            this.list[this.list.IndexOf(linuxMint)].namingRules = this.namingRules.Text;
            this.list[this.list.IndexOf(linuxMint)].fileManager = this.fileManager.Text;
        }
        private void EditProperties(LinuxMintDebianEdition linuxMintDebianEdition) {
            EditRequiredProperties(linuxMintDebianEdition);
            this.list[this.list.IndexOf(linuxMintDebianEdition)].fileManager = this.fileManager.Text;
        }

        private void EditProperties(ElementaryOS elementaryOS) {
            EditRequiredProperties(elementaryOS);
            this.list[this.list.IndexOf(elementaryOS)].imageName = this.imageName.Text;
            this.list[this.list.IndexOf(elementaryOS)].namingRules = this.namingRules.Text;
            this.list[this.list.IndexOf(elementaryOS)].installer = this.installer.Text;
        }
        private void EditProperties(SolusOS solusOS) {
            EditRequiredProperties(solusOS);
            this.list[this.list.IndexOf(solusOS)].fileManager = this.fileManager.Text;
            this.list[this.list.IndexOf(solusOS)].installer = this.installer.Text;
        }
        private void EditProperties(CommodoreOS commodoreOS) {
            EditRequiredProperties(commodoreOS);
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
            this.SetupRequiredValues();
            this.SetupField(this.listComboBox[this.comboBox.SelectedIndex]);
        }
    }
}
