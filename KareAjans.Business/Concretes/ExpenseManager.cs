using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class ExpenseManager : IExpenseService
    {

        private readonly IExpenseRepository _expenseRepository;
        public ExpenseManager(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }



        public List<ExpenseDTO> GetExpenses()
        {
            throw new NotImplementedException();
        }

        public void AddExpense(ExpenseDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteExpense(ExpenseDTO dto)
        {
            throw new NotImplementedException();
        }

        public void UpdateExpense(ExpenseDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
