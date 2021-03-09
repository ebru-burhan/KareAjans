using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IIncomeService : IService
    {
        List<IncomeDTO> GetIncomes();
        void AddIncome(IncomeDTO dto);
        void DeleteIncome(IncomeDTO dto);
        void UpdateIncome(IncomeDTO dto);
        IncomeDTO GetIncomeById(int id, bool isOrganizationIncluded = false);
    }
}
