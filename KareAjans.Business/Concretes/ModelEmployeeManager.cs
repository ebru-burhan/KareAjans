using AutoMapper;
using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class ModelEmployeeManager : IModelEmployeeService
    {
        private readonly IModelEmployeeRepository _modelEmployeeRepository;
        private readonly IMapper _mapper;
        public ModelEmployeeManager(IModelEmployeeRepository modelEmployeeRepository , IMapper mapper)
        {
            _modelEmployeeRepository = modelEmployeeRepository;
            _mapper = mapper;
        }


        public List<ModelEmployeeDTO> GetModelEmployees()
        {
            var modelEmployees = _modelEmployeeRepository.GetIncluded(x => x.Pictures ,x=> x.ProfessionalDegree);
            return _mapper.Map<List<ModelEmployeeDTO>>(modelEmployees);
        }

        public void AddModelEmployee(ModelEmployeeDTO dto)
        {
            _modelEmployeeRepository.Add(_mapper.Map<ModelEmployee>(dto));
        }

        public void DeleteModelEmployee(ModelEmployeeDTO dto)
        {
            _modelEmployeeRepository.Delete(_mapper.Map<ModelEmployee>(dto));
        }

        public void UpdateModelEmployee(ModelEmployeeDTO dto)
        {
            _modelEmployeeRepository.Update(_mapper.Map<ModelEmployee>(dto));
        }

        public ModelEmployeeDTO GetModelEmployee(int id)
        {
           var modelEmployee = _modelEmployeeRepository.Get(x => x.ModelEmployeeID == id).FirstOrDefault();
            return _mapper.Map<ModelEmployeeDTO>(modelEmployee);
        }

        public ModelEmployeeDTO GetModelEmployeeByUser(UserDTO userDto)
        {
           var modelEmployee = _modelEmployeeRepository.Get(x => x.UserId == userDto.UserID).FirstOrDefault();
            return _mapper.Map<ModelEmployeeDTO>(modelEmployee);
        }
    }
}
