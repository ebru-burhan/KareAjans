using KareAjans.Entity;
using KareAjans.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Model.ProjectBaseDTO
{
    public class ModelEmployeeDTO
    {
        public int ID { get; set; }
        public int ProfessionalDegreeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public byte Age { get; set; }
        public byte Weight { get; set; }
        public byte Height { get; set; }
        public ShoeSize ShoeSize { get; set; }
        public EyeColor EyeColor { get; set; }
        public HairColor HairColor { get; set; }
        public Gender Gender { get; set; }
        public bool DrivingLicence { get; set; }
        public bool WorkingOutsideTheCity { get; set; }
        public string ForeignLanguage { get; set; }
        public string Speciality { get; set; }

        //enum vardı size
        //public Size Size { get; set; }


        //relations-------
        public ProfessionalDegreeDTO ProfessionalDegree { get; set; }
        public List<PictureDTO> PictureList { get; set; }


        //authorizeyapılacak adminler görücek yorum yazıcak mankenler görmicek yorum yazmıcak örn
        public List<CommentDTO> CommentList { get; set; }
    }
}
