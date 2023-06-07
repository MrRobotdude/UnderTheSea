using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderTheSea.ViewModels
{
    public class ManagerViewModel:Conductor<object>
    {
        private static ManagerViewModel instance;

        public static ManagerViewModel getInstance()
        {
            if (instance == null)
            {
                instance = new ManagerViewModel();
            }
            return instance;
        }

        public ManagerViewModel()
        {
            ActivateItem(new ManRequestViewModel());
            instance = this;
        }

        public void showRequestView()
        {
            ActivateItem(new ManRequestViewModel());
        }

        public void incomeBtn()
        {
            ActivateItem(new ManIncomeViewModel());
        }
        public void resignBtn()
        {
            ActivateItem(new ManResignViewModel());
        }
        public void BtnSignOut()
        {
            ShellViewModel viewModel = ShellViewModel.getInstance();
            viewModel.ShowLoginView();
        }
    }
}
