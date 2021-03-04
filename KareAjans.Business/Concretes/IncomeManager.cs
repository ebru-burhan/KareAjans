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
    public class IncomeManager : IIncomeService
    {

        private readonly IIncomeRepository _incomeRepository;
        private readonly IMapper _mapper;
        public IncomeManager(IIncomeRepository incomeRepository, IMapper mapper)
        {
            _incomeRepository = incomeRepository;
            _mapper = mapper;
        }


        public List<IncomeDTO> GetIncomes()
        {
            var incomes = _incomeRepository.GetAll();
            return _mapper.Map<List<IncomeDTO>>(incomes);

        }

        public void AddIncome(IncomeDTO dto)
        {
            _incomeRepository.Add(_mapper.Map<Income>(dto));
        }

        public void DeleteIncome(IncomeDTO dto)
        {
            _incomeRepository.Delete(_mapper.Map<Income>(dto));
        }

        public void UpdateIncome(IncomeDTO dto)
        {
            _incomeRepository.Update(_mapper.Map<Income>(dto));
        }
    }
}
