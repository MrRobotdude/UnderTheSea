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
using UnderTheSea.ViewModels;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for DRDEatMethod.xaml
    /// </summary>
    public partial class DRDEatMethodView : Window
    {
        //private DiningRoomDivisionViewModel viewModel;
        //private int employeeID;
        public DRDEatMethodView()
        {
            InitializeComponent();
            //viewModel = DiningRoomDivisionViewModel.getInstance();
        }

        //private void takeAwayBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    viewModel.showMenu();
        //    this.Close();
        //}

        //private void DineInBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    viewModel.showCheckTable();
        //    this.Close();
        //}
    }
}
