using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IExpenseService : IService
    {
        List<ExpenseDTO> GetExpenses();
        void AddExpense(ExpenseDTO dto);
        void DeleteExpense(ExpenseDTO dto);
        void UpdateExpense(ExpenseDTO dto);

        List<ExpenseDTO> GetExpenseWithExpenseType();
    }
}
