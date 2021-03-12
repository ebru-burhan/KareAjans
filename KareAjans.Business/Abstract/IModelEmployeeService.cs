﻿using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IModelEmployeeService : IService
    {

        List<ModelEmployeeDTO> GetModelEmployees();
        void AddModelEmployee(ModelEmployeeDTO dto);
        void DeleteModelEmployee(ModelEmployeeDTO dto);
        void UpdateModelEmployee(ModelEmployeeDTO dto);
        ModelEmployeeDTO GetModelEmployeeById(int id, bool professionalDegreeIncluded = false);
        ModelEmployeeDTO GetModelEmployeeByUser(UserDTO userDto);
        List<ModelEmployeeDTO> GetModelEmployeesWithIncludes();
        ModelEmployeeDTO GetModelEmployeeByIdWithIncluded(int id);

    }
}
