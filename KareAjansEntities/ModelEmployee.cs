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
        public DateTime DateOfBirth { get; set; }
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

        public User User { get; set; }
        public ProfessionalDegree ProfessionalDegree { get; set; }
        public ICollection<Picture> Pictures { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<ModelEmployeeOrganization> ModelEmployeeOrganizations { get; set; }
    }
}
