using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class ModelEmployeeManager : IModelEmployeeService
    {
        private readonly IModelEmployeeRepository _modelEmployeeRepository;
        public ModelEmployeeManager(IModelEmployeeRepository modelEmployeeRepository)
        {
            _modelEmployeeRepository = modelEmployeeRepository;
        }


        public List<ModelEmployeeDTO> GetModelEmployees()
        {
            throw new NotImplementedException();
        }

        public void AddModelEmployee(ModelEmployeeDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteModelEmployee(ModelEmployeeDTO dto)
        {
            throw new NotImplementedException();
        }

        public void UpdateModelEmployee(ModelEmployeeDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
