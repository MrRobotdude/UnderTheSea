using Caliburn.Micro;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class KDMenuViewModel:Screen
    {
        private Menu da;
        private Menu myVar;

        public Menu SelectedMenu
        {
            get { return myVar; }
            set { myVar = value;
                NotifyOfPropertyChange(() => SelectedMenu);
            }
        }


        public BindableCollection<Menu> Menu { get; set; }
        public KDMenuViewModel()
        {
            da = new Menu();
            Menu = new BindableCollection<Menu>(da.getAllMenu());
        }
        public void btnCreate()
        {
            IWindowManager manager = new WindowManager();
            manager.ShowWindow(new KDMenuInsertViewModel(), null, null);
        }
        public void btnDelete()
        {
            da.DeleteMenu(SelectedMenu.MenuID);
        }
        public void btnUpdate()
        {
            da.UpdateMenu(SelectedMenu);
        }
    }
}
