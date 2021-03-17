using KareAjans.Entity.Enums;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IModelEmployeeService : IService
    {

        List<ModelEmployeeDTO> GetModelEmployees();
        void AddModelEmployee(ModelEmployeeDTO dto , UserDTO userdto, PictureDTO pictureDto);
        void DeleteModelEmployee(ModelEmployeeDTO dto);
        void UpdateModelEmployee(ModelEmployeeDTO dto);
        ModelEmployeeDTO GetModelEmployeeById(int id, bool professionalDegreeIncluded = false);
        ModelEmployeeDTO GetModelEmployeeByUser(UserDTO userDto);
        List<ModelEmployeeDTO> GetModelEmployeesWithIncludes();
        ModelEmployeeDTO GetModelEmployeeByIdWithIncluded(int id);


        List<ModelEmployeeDTO> GetModelEmployeesSearch(string firstName, string lastName, Gender? gender, ShoeSize? shoeSize, EyeColor? eyeColor, HairColor? hairColor, BodySize? bodySize, int age, byte weight, byte height, int professionalDegreeId, string foreignLanguage, bool? hasDrivingLicence, bool? isWorkingOutsideTheCity, int organizationId);

    }
}
