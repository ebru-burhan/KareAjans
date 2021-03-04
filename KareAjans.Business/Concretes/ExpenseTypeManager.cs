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
    public class ExpenseTypeManager : IExpenseTypeService
    {
        private readonly IExpenseTypeRepository _expenseTypeRepository;
        private readonly IMapper _mapper;
        public ExpenseTypeManager(IExpenseTypeRepository expenseTypeRepository, IMapper mapper)
        {
            _expenseTypeRepository = expenseTypeRepository;
            _mapper = mapper;
        }



        public List<ExpenseTypeDTO> GetExpenseTypes()
        {
            var expenseTypes = _expenseTypeRepository.GetAll();
            return _mapper.Map<List<ExpenseTypeDTO>>(expenseTypes);
        }

        public void AddExpenseType(ExpenseTypeDTO dto)
        {
            _expenseTypeRepository.Add(_mapper.Map<ExpenseType>(dto));
        }

        public void DeleteExpenseType(ExpenseTypeDTO dto)
        {
            _expenseTypeRepository.Delete(_mapper.Map<ExpenseType>(dto));
        }

        public void UpdateExpenseType(ExpenseTypeDTO dto)
        {
            _expenseTypeRepository.Update(_mapper.Map<ExpenseType>(dto));
        }
    }
}
