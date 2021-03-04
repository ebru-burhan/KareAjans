using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjansUI.ViewModels
{
    public class ModelEmployeeViewModel
    {
        // TODO: detay eklersek gerekli propları başka sayfada göstermek için id gerek sonra bak

        //public int ModelEmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public string PictureUrl { get; set; }


    }
}
