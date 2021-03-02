using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class ExpenseTypeManager : IExpenseTypeService
    {
        private readonly IExpenseTypeRepository _expenseTypeRepository;
        public ExpenseTypeManager(IExpenseTypeRepository expenseTypeRepository)
        {
            _expenseTypeRepository = expenseTypeRepository;
        }



        public List<ExpenseTypeDTO> GetExpenseTypes()
        {
            throw new NotImplementedException();
        }

        public void AddExpenseType(ExpenseTypeDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteExpenseType(ExpenseTypeDTO dto)
        {
            throw new NotImplementedException();
        }

        public void UpdateExpenseType(ExpenseTypeDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
