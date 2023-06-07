using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderTheSea.Models;

namespace UnderTheSea.ViewModels
{
    public class KDMenuInsertViewModel:Screen
    {
        private Menu da;
        public string MenuName { get; set; }
        public int MenuPrice { get; set; }
        public string LblWarning { get; set; }
        public KDMenuInsertViewModel()
        {
            da = new Menu();
        }
        public void btnInsert()
        {
            if(MenuName=="" || MenuPrice <= 0)
            {
                LblWarning = "Wrong Input";
            }
            else
            {
                da.insertMenu(MenuName,MenuPrice); 
            }
        }
    }
}
