using KareAjans.Business.Abstract;
using KareAjans.Entity.Enums;
using KareAjans.Model;
using KareAjans.UI.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.Controllers
{
    public class ModelEmployeeController : Controller
    {
   
        private readonly IModelEmployeeService _modelEmployeeService;
        private readonly IProfessionalDegreeService _professionalDegreeService;
        private readonly ICommentService _commentService;
        private readonly IPictureService _pictureService;
        private readonly IOrganizationService _organizationService;

        //resim yükleme
        private readonly IWebHostEnvironment _env;
        private string directory;

        public ModelEmployeeController(IModelEmployeeService modelEmployeeService, IProfessionalDegreeService professionalDegreeService, ICommentService commentService, IPictureService pictureService, IOrganizationService organizationService,
            IWebHostEnvironment env)
        {
            _modelEmployeeService = modelEmployeeService;
            _professionalDegreeService = professionalDegreeService;
            _commentService = commentService;
            _pictureService = pictureService;
            _organizationService = organizationService;

            _env = env;
            //nereye kaydolacağı yüklemenin = yoda commenti
            directory = _env.WebRootPath + "/images/";
        }

        [HttpGet]
        public IActionResult Index()
        {
            var modelEmployees = _modelEmployeeService.GetModelEmployeesWithIncludes();
            List<ModelEmployeeViewModel> modelList = new List<ModelEmployeeViewModel>();

            foreach (var item in modelEmployees)
            {
                int age = DateTime.Today.Year - item.DateOfBirth.Year;

                ModelEmployeeViewModel model = new ModelEmployeeViewModel()
                {
                    ModelEmployeeID = item.ModelEmployeeID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Age = age,
                    Gender = item.Gender.ToString(),
                    Title = item.ProfessionalDegree.Title,
                };
                modelList.Add(model);
            }
            return View(modelList);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var dto = _modelEmployeeService.GetModelEmployeeByIdWithIncluded(id);

            int age = DateTime.Today.Year - dto.DateOfBirth.Year;

            ModelEmployeeDetailViewModel modelDetail = new ModelEmployeeDetailViewModel()
            {
                ModelEmployeeID = id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Age = age,
                Gender = dto.Gender.ToString(),
                Title = dto.ProfessionalDegree.Title,

                Weight = dto.Weight,
                Height = dto.Height,
                ShoeSize = (int)dto.ShoeSize,
                EyeColor = dto.EyeColor.ToString(),
                HairColor = dto.HairColor.ToString(),
                BodySize = dto.BodySize.ToString(),

                DateOfBirth = dto.DateOfBirth,
                Email = dto.User.Email,
                Address = dto.Address,
                PhoneNo1 = dto.PhoneNo1,
                PhoneNo2 = dto.PhoneNo2,
                DrivingLicence = dto.DrivingLicence,
                WorkingOutsideTheCity = dto.WorkingOutsideTheCity,
                ForeignLanguage = dto.ForeignLanguage,
                Speciality = dto.Speciality,
                Comments = dto.Comments,
                Pictures = dto.Pictures,
                Comment = new CommentDTO()
                
            };

            return View(modelDetail);
        }

        #region ModelEmployeeAddUpdateDelete
        [HttpGet]
        public IActionResult Add()
        {
            ModelEmployeeAddViewModel model = new ModelEmployeeAddViewModel()
            {
                ModelEmployee = new ModelEmployeeDTO(),
                ProfessionelDegrees = _professionalDegreeService.GetProfessionalDegrees()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(ModelEmployeeAddViewModel model)
        {
            var picturePath = "image_" + Guid.NewGuid().ToString() + ".png";

            using (var fileStream = new FileStream(Path.Combine(directory, picturePath), FileMode.Create, FileAccess.Write))
            {
                model.Picture.CopyTo(fileStream);
            }

            UserDTO userDto = new UserDTO()
            {
                FirstName = model.ModelEmployee.FirstName,
                LastName = model.ModelEmployee.LastName,
                Email = model.Email,
                Password = model.Password
            };

            PictureDTO pictureDto = new PictureDTO()
            {
                Url = picturePath
            };

            _modelEmployeeService.AddModelEmployee(model.ModelEmployee, userDto, pictureDto);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {

            ModelEmployeeAddViewModel model = new ModelEmployeeAddViewModel()
            {
                ModelEmployee = _modelEmployeeService.GetModelEmployeeById(id),
                ProfessionelDegrees = _professionalDegreeService.GetProfessionalDegrees()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(ModelEmployeeAddViewModel model)
        {
            _modelEmployeeService.UpdateModelEmployee(model.ModelEmployee);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            
            _modelEmployeeService.DeleteModelEmployee(_modelEmployeeService.GetModelEmployeeById(id));
            return RedirectToAction(nameof(Index));
        }
        #endregion


        [HttpPost]
        public IActionResult AddComment(ModelEmployeeDetailViewModel model)
        {
            CommentDTO addedComment = model.Comment;
            addedComment.ModelEmployeeId = model.ModelEmployeeID;
            _commentService.AddComment(addedComment);

            return RedirectToAction(nameof(Detail), new { id = model.ModelEmployeeID });
        }

        [HttpGet]
        public IActionResult DeleteComment(int id)
        {
            var dto = _commentService.GetCommentById(id);
            _commentService.DeleteComment(dto);
            return RedirectToAction(nameof(Detail), new { id = dto.ModelEmployeeId });
        }

        [HttpPost]
        public IActionResult AddPicture(ModelEmployeeDetailViewModel model)
        {
            var picturePath = "image_" + Guid.NewGuid().ToString() + ".png";

            using (var fileStream = new FileStream(Path.Combine(directory, picturePath), FileMode.Create, FileAccess.Write))
            {
                model.Picture.CopyTo(fileStream);
            }

            PictureDTO addedPicture = new PictureDTO()
            {
                ModelEmployeeId = model.ModelEmployeeID,
                Url = picturePath
            };
            _pictureService.AddPicture(addedPicture);
            return RedirectToAction(nameof(Detail), new { id = model.ModelEmployeeID });
        }

        [HttpGet]
        public IActionResult DeletePicture(int id)
        {
            var dto = _pictureService.GetPictureById(id);
            _pictureService.DeletePicture(dto);
            return RedirectToAction(nameof(Detail), new { id = dto.ModelEmployeeId });
        }


        [HttpGet]
        public IActionResult Search(string firstName, string lastName, Gender? gender , ShoeSize? shoeSize, EyeColor? eyeColor, HairColor? hairColor, BodySize? bodySize, int age, byte weight, byte height, int professionalDegreeId, string foreignLanguage, bool? hasDrivingLicence, bool? isWorkingOutsideTheCity, int organizationId)
        {

           var dtolist = _modelEmployeeService.GetModelEmployeesSearch(firstName, lastName, gender, shoeSize, eyeColor, hairColor, bodySize, age, weight, height, professionalDegreeId, foreignLanguage, hasDrivingLicence, isWorkingOutsideTheCity, organizationId);

            List<ModelEmployeeDetailViewModel> modelList = new List<ModelEmployeeDetailViewModel>();

            foreach (var dto in dtolist)
            {
                int dtoAge = DateTime.Today.Year - dto.DateOfBirth.Year;

                ModelEmployeeDetailViewModel model = new ModelEmployeeDetailViewModel
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Gender = dto.Gender.ToString(),
                    Title = dto.ProfessionalDegree.Title,
                    Age = dtoAge,
                    Weight = dto.Weight,
                    Height = dto.Height,
                    ShoeSize = (int)dto.ShoeSize,
                    EyeColor = dto.EyeColor.ToString(),
                    HairColor = dto.HairColor.ToString(),
                    BodySize = dto.BodySize.ToString(),
                    DrivingLicence = dto.DrivingLicence,
                    WorkingOutsideTheCity = dto.WorkingOutsideTheCity,
                    ForeignLanguage = dto.ForeignLanguage
                };
                modelList.Add(model);
            }

            ModelEmployeeSearchViewModel searchModel = new ModelEmployeeSearchViewModel()
            {
                SearchResults = modelList,
                ProfessionalDegrees = _professionalDegreeService.GetProfessionalDegrees(),
                Organizations = _organizationService.GetOrganizations()
            };


            return View(searchModel);
        }

    }
}
