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
    public class ExpenseManager : IExpenseService
    {

        private readonly IExpenseRepository _expenseRepository;
        private readonly IMapper _mapper;
        public ExpenseManager(IExpenseRepository expenseRepository , IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }



        public List<ExpenseDTO> GetExpenses()
        {
            var expenses =  _expenseRepository.GetAll();
            return _mapper.Map<List<ExpenseDTO>>(expenses);
        }

        public void AddExpense(ExpenseDTO dto)
        {
            _expenseRepository.Add(_mapper.Map<Expense>(dto));
        }

        public void DeleteExpense(ExpenseDTO dto)
        {
            _expenseRepository.Delete(_mapper.Map<Expense>(dto));
        }

        public void UpdateExpense(ExpenseDTO dto)
        {
            _expenseRepository.Update(_mapper.Map<Expense>(dto));
        }
    }
}
