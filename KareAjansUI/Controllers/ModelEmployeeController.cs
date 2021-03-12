using KareAjans.Business.Abstract;
using KareAjans.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.Controllers
{
    public class ModelEmployeeController : Controller
    {
        private readonly IModelEmployeeService _modelEmployeeService;

        public ModelEmployeeController(IModelEmployeeService modelEmployeeService)
        {
            _modelEmployeeService = modelEmployeeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var modelEmployees = _modelEmployeeService.GetModelEmployeesWithIncludes();
            List<ModelEmployeeViewModel> modelList = new List<ModelEmployeeViewModel>();

            foreach (var item in modelEmployees)
            {
                int age = DateTime.Today.Year - item.DateOfBirth.Year;
                // TODO: Age validation
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
            // TODO: Age validation
            ModelEmployeeDetailViewModel modelDetail = new ModelEmployeeDetailViewModel()
            {
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
                Pictures = dto.Pictures
            };

            return View(modelDetail);
        }
    }
}
