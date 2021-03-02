using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IExpenseTypeService : IService
    {
        List<ExpenseTypeDTO> GetExpenseTypes();
        void AddExpenseType(ExpenseTypeDTO dto);
        void DeleteExpenseType(ExpenseTypeDTO dto);
        void UpdateExpenseType(ExpenseTypeDTO dto);
    }
}
