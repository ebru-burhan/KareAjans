using KareAjans.Entity.Abstracts;
using KareAjans.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class ModelEmployee : BaseEntity
    {
        public int ModelEmployeeID { get; set; }
        public int ProfessionalDegreeId { get; set; }
        public int UserId { get; set; }
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
        public BodySize BodySize { get; set; }
        public bool DrivingLicence { get; set; }
        public bool WorkingOutsideTheCity { get; set; }
        public string ForeignLanguage { get; set; }
        public string Speciality { get; set; }




        //relations-------

        public virtual User User { get; set; }
        public virtual ProfessionalDegree ProfessionalDegree { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }


        //authorizeyapılacak adminler görücek yorum yazıcak mankenler görmicek yorum yazmıcak örn
        public virtual ICollection<Comment> Comments { get; set; }

        // TODO: override oncreating yapcaz onconfig yapılan yerde  hasone foregign ilişkisini göstercen
        public virtual ICollection<ModelEmployeeOrganization> ModelEmployeeOrganizations { get; set; }


    }
}
