using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using UnderTheSea.Models;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for MakeAdvertisementView.xaml
    /// </summary>
    public partial class MakeAdvertisementView : UserControl
    {
        private Advertisement advertisementDA = new Advertisement(); 
        public MakeAdvertisementView()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string desc = new TextRange(descTextBox.Document.ContentStart, descTextBox.Document.ContentEnd).Text;
            advertisementDA.insertAdvertisement(NameTxtBox.Text,desc);
        }
    }
}
