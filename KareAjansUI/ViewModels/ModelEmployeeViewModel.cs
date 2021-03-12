using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.ViewModels
{
    public class ModelEmployeeViewModel
    {

        //manken listesinde detay kullancaz id ile
        public int ModelEmployeeID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }


        public string Gender { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }







        //home da bi tane foto göstermek için kullandık
        //belki arama da kullanabilirz arama sonucu resimli gelsin diye??
        public string PictureUrl { get; set; }


    }
}
