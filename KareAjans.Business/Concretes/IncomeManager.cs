using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class IncomeManager : IIncomeService
    {

        private readonly IIncomeRepository _incomeRepository;
        public IncomeManager(IIncomeRepository incomeRepository)
        {
            _incomeRepository = incomeRepository;
        }


        public List<IncomeDTO> GetIncomes()
        {
            throw new NotImplementedException();
        }

        public void AddIncome(IncomeDTO dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteIncome(IncomeDTO dto)
        {
            throw new NotImplementedException();
        }

        public void UpdateIncome(IncomeDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
