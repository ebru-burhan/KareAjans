using AutoMapper;
using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using KareAjans.Entity.Enums;
using KareAjans.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class ModelEmployeeManager : IModelEmployeeService
    {
        private readonly IModelEmployeeRepository _modelEmployeeRepository;
        private readonly IModelEmployeeOrganizationRepository _modelEmployeeOrganizationRepository;

        private readonly IUserService _userService;
        private readonly IPictureService _pictureService;
        private readonly IOrganizationService _organizationService;
        private readonly IMapper _mapper;
        public ModelEmployeeManager(IModelEmployeeRepository modelEmployeeRepository , IModelEmployeeOrganizationRepository modelEmployeeOrganizationRepository,
            IUserService userService, IPictureService pictureService, IOrganizationService organizationService,
            IMapper mapper)
        {
            _modelEmployeeRepository = modelEmployeeRepository;
            _modelEmployeeOrganizationRepository = modelEmployeeOrganizationRepository;

            _userService = userService;
            _pictureService = pictureService;
            _organizationService = organizationService;
            _mapper = mapper;
        }


        public List<ModelEmployeeDTO> GetModelEmployees()
        {
            var modelEmployees = _modelEmployeeRepository.GetIncluded(x => x.Pictures, x => x.ProfessionalDegree);
            return _mapper.Map<List<ModelEmployeeDTO>>(modelEmployees);
        }

        public void AddModelEmployee(ModelEmployeeDTO dto, UserDTO userDto, PictureDTO pictureDTO)
        {
            userDto.PermissionId = (int)UserType.ModelEmployee;
            UserDTO addedUserDto = _userService.AddUser(userDto);
            dto.UserId = addedUserDto.UserID;
            ModelEmployee modelEmployee = _modelEmployeeRepository.Add(_mapper.Map<ModelEmployee>(dto));

            pictureDTO.ModelEmployeeId = modelEmployee.ModelEmployeeID;
            _pictureService.AddPicture(pictureDTO);
           
        }

        public void DeleteModelEmployee(ModelEmployeeDTO dto)
        {
            _userService.DeleteUser(_userService.GetUserById(dto.UserId));
            _modelEmployeeRepository.Delete(_mapper.Map<ModelEmployee>(dto));
        }

        public void UpdateModelEmployee(ModelEmployeeDTO dto)
        {
            _modelEmployeeRepository.Update(_mapper.Map<ModelEmployee>(dto));
        }

        public ModelEmployeeDTO GetModelEmployeeById(int id, bool professionalDegreeIncluded = false)
        {
            ModelEmployee modelEmployee = null;
            if (professionalDegreeIncluded)
            {
                 modelEmployee = _modelEmployeeRepository.Get(x => x.ModelEmployeeID == id , x => x.ProfessionalDegree).FirstOrDefault();
            }
            else
            {
                modelEmployee = _modelEmployeeRepository.Get(x => x.ModelEmployeeID == id).FirstOrDefault();
            }
     
            return _mapper.Map<ModelEmployeeDTO>(modelEmployee);
        }

        public ModelEmployeeDTO GetModelEmployeeByUser(UserDTO userDto)
        {
           var modelEmployee = _modelEmployeeRepository.Get(x => x.UserId == userDto.UserID, x => x.Pictures).FirstOrDefault();
            return _mapper.Map<ModelEmployeeDTO>(modelEmployee);
        }

        public List<ModelEmployeeDTO> GetModelEmployeesWithIncludes()
        {
            var modelEmployees = _modelEmployeeRepository.GetIncluded(x => x.Pictures, x => x.ProfessionalDegree, x => x.User, x => x.User.Permission, x => x.Comments);
            return _mapper.Map<List<ModelEmployeeDTO>>(modelEmployees);
        }

        public ModelEmployeeDTO GetModelEmployeeByIdWithIncluded(int id)
        {
            var modelEmployee = _modelEmployeeRepository.GetFilteredIncluded(x => x.ModelEmployeeID == id , x => x.Pictures, x => x.ProfessionalDegree, x => x.User, x => x.User.Permission, x => x.Comments).FirstOrDefault();
            return _mapper.Map<ModelEmployeeDTO>(modelEmployee);
        }

        public List<ModelEmployeeDTO> GetModelEmployeesSearch(string firstName, string lastName, Gender? gender, ShoeSize? shoeSize, EyeColor? eyeColor, HairColor? hairColor, BodySize? bodySize, int age, byte weight, byte height, int professionalDegreeId, string foreignLanguage, bool? hasDrivingLicence, bool? isWorkingOutsideTheCity, int organizationId)
        {
            var modelEmployees = _modelEmployeeRepository.GetIncluded(x => x.ProfessionalDegree);

            if (!String.IsNullOrEmpty(firstName))
            {
                 modelEmployees = modelEmployees.Where(x => x.FirstName.Contains(firstName));
            }

            if (!String.IsNullOrEmpty(lastName))
            {
                modelEmployees = modelEmployees.Where(x => x.LastName.Contains(lastName));
            }

            //hasvalue == null check mişş
            if (gender != null)
            {
                //enum ? ile null olabilir hale getrdik 
                modelEmployees = modelEmployees.Where(x => x.Gender == gender.Value);
            }

            if (shoeSize.HasValue)
            {
                modelEmployees = modelEmployees.Where(x => x.ShoeSize == shoeSize.Value);
            }

            if (eyeColor.HasValue)
            {
                modelEmployees = modelEmployees.Where(x => x.EyeColor == eyeColor.Value);
            }

            if (hairColor.HasValue)
            {
                modelEmployees = modelEmployees.Where(x => x.HairColor == hairColor.Value);
            }

            if (bodySize.HasValue)
            {
                modelEmployees = modelEmployees.Where(x => x.BodySize == bodySize.Value);
            }

            if (age != 0)
            {
                modelEmployees = modelEmployees.Where(x => (DateTime.Now.Year - x.DateOfBirth.Year) == age );
            }

            if (weight != 0)
            {
                modelEmployees = modelEmployees.Where(x => x.Weight == weight);
            }

            if (height != 0)
            {
                modelEmployees = modelEmployees.Where(x => x.Height == height);
            }

            if (professionalDegreeId != 0)
            {
                modelEmployees = modelEmployees.Where(x => x.ProfessionalDegreeId == professionalDegreeId);
            }

            if (!String.IsNullOrEmpty(foreignLanguage))
            {
                modelEmployees = modelEmployees.Where(x => x.ForeignLanguage.Contains(foreignLanguage));
            }

            if (hasDrivingLicence != null)
            {
                modelEmployees = modelEmployees.Where(x => x.DrivingLicence == hasDrivingLicence);
            }

            //sadece organizaitonId olmadığında dikkate alıcaz çünkü arama da organizaiton un localliği ile arama çakışıyo çelişiyo
            if (isWorkingOutsideTheCity != null && organizationId == 0)
            {              
                modelEmployees = modelEmployees.Where(x => x.WorkingOutsideTheCity == isWorkingOutsideTheCity);
            }

            // ThenInclude hemen önceki include edilen tablonun içinde tekrar include etmeyi sağlıyo wooww
            // TODO: ThenInclude kullanılacak bazı yerler varsanırım zaman kalırsa yapılabilirrr
            
            if (organizationId != 0)
            {
                var organizationSelected = _organizationService.GetOrganizationById(organizationId);
                //.Where(x => x.WorkingOutsideTheCity == organizationSelected.IsLocal)
                modelEmployees = modelEmployees.Include(x => x.ModelEmployeeOrganizations).ThenInclude(x => x.Organization);

                if (organizationSelected.IsLocal == false)
                {
                    modelEmployees = modelEmployees.Where(x => x.WorkingOutsideTheCity == true);
                }

                //modelEmployees = modelEmployees.SelectMany(x => x.ModelEmployeeOrganizations).Where(x => x.Organization.EndingDate != organizationSelected.StartingDate).Select(x => x.ModelEmployee);
                // && x.Organization.StartingDate > organizationSelected.EndingDate
                /*
                modelEmployees = modelEmployees.Where(x => x.ModelEmployeeOrganizations  Organization.EndingDate < organizationSelected.StartingDate && x.Organization.StartingDate > organizationSelected.EndingDate);
                */

               
                var modelEmployeeList = modelEmployees.ToList();

                // TODO: manken görevlendirme için theninclude lu where li sql sorgusu olmalı araştır joinli olmalı 
                // list ile somutlaştırdık işlem yapmak için, querable lar soyut, yol açıyomuş veri aktarma için, işlem yapılamıyomuş ilginç, güzel 
                List<ModelEmployee> filteredEmployees = new List<ModelEmployee>();

                foreach (var modelEmployee in modelEmployees)
                {
                    if (modelEmployee.ModelEmployeeOrganizations.Count == 0)
                    {
                        filteredEmployees.Add(modelEmployee);
                    }
                    else
                    {
                        foreach (var modelOrganization in modelEmployee.ModelEmployeeOrganizations)
                        {
                            if (modelOrganization.Organization.EndingDate < organizationSelected.StartingDate && modelOrganization.Organization.StartingDate < organizationSelected.EndingDate)
                            {
                                filteredEmployees.Add(modelEmployee);
                            }
                        }
                    }
                }

                return _mapper.Map<List<ModelEmployeeDTO>>(filteredEmployees);
            }

            return _mapper.Map<List<ModelEmployeeDTO>>(modelEmployees);
        }



        //----------
        public void AssignModelEmployee(int modelEmployeeId, int organizationId)
        {
            ModelEmployeeDTO modelEmployeeDto = GetModelEmployeeById(modelEmployeeId, true);
            OrganizationDTO organizationDto = _organizationService.GetOrganizationById(organizationId);

            ModelEmployeeOrganizationDTO modelEmployeeOrganizationDto = new ModelEmployeeOrganizationDTO()
            {
                ModelEmployeeId = modelEmployeeDto.ModelEmployeeID,
                OrganizationId = organizationDto.OrganizationID
            };

            _modelEmployeeOrganizationRepository.Add(_mapper.Map<ModelEmployeeOrganization>(modelEmployeeOrganizationDto));
        }
    }
}
