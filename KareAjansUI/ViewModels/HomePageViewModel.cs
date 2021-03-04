using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjansUI.ViewModels
{
    public class HomePageViewModel
    {
        //sitecontent
        public string AboutText { get; set; }
        public string ReferencesText { get; set; }

        //model employee
        public List<ModelEmployeeViewModel> ModelEmployees { get; set; }

        //picturre
    }
}
