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
using UnderTheSea.ViewModels;

namespace UnderTheSea.Views
{
    /// <summary>
    /// Interaction logic for ConstructionDepartmentView.xaml
    /// </summary>
    public partial class ConstructionDepartmentView : UserControl
    {
        
        public ConstructionDepartmentView()
        {
            InitializeComponent();
            //ConstructionDepartmentViewModel viewModel = ConstructionDepartmentViewModel.getInstance();
            //viewModel.showHandleConstructionView();
        }

        //private void constructionBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    ConstructionDepartmentViewModel viewModel = ConstructionDepartmentViewModel.getInstance();
        //    viewModel.showHandleConstructionView();
        //}

        //private void purchaseBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    ConstructionDepartmentViewModel viewModel = ConstructionDepartmentViewModel.getInstance();
        //    viewModel.showSendPurchaseRequest();
            
        //}

        //private void fundBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    ConstructionDepartmentViewModel viewModel = ConstructionDepartmentViewModel.getInstance();
        //    viewModel.showSendFundRequest();
        //}
    }
}
