using KareAjans.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.ViewModels
{
    public class ModelEmployeeDetailViewModel : ModelEmployeeViewModel
    {


        //manken  detay sayfasında syfanın sağında
        public byte Weight { get; set; }
        public byte Height { get; set; }
        public int ShoeSize { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string BodySize { get; set; }


        //manken detay sayfasında sayfann solunda olsun
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public bool DrivingLicence { get; set; }
        public bool WorkingOutsideTheCity { get; set; }
        public string ForeignLanguage { get; set; }
        public string Speciality { get; set; }

        //listeleme için
        public List<CommentDTO> Comments { get; set; }
        public List<PictureDTO> Pictures { get; set; }

        //ekleme işlemi için
        public CommentDTO Comment { get; set; }
        public IFormFile Picture { get; set; }



        /*
        //manken adı aratıp hangi organizasyonlarda çalışmış çalışıyo
        //arama da kullanılcak dursun şimdilk
        public string[] Organizations { get; set; }
        */
    }
}
