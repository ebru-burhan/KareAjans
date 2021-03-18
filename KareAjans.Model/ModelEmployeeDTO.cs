using KareAjans.Entity;
using KareAjans.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KareAjans.Model
{
    public class ModelEmployeeDTO
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

        [Range(0, byte.MaxValue, ErrorMessage = "Lütfen {1}'dan büyük değer giriniz.")]
        public byte Weight { get; set; }
        [Range(0, byte.MaxValue, ErrorMessage = "Lütfen {1}'dan büyük değer giriniz.")]
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
        public DateTime CreatedDate { get; set; }


        //relations-------

        public UserDTO User { get; set; }
        public ProfessionalDegreeDTO ProfessionalDegree { get; set; }
        public List<PictureDTO> Pictures { get; set; }


        //authorizeyapılacak adminler görücek yorum yazıcak mankenler görmicek yorum yazmıcak örn
        public List<CommentDTO> Comments { get; set; }

        public List<ModelEmployeeOrganizationDTO> ModelEmployeeOrganizations { get; set; }
    }
}
