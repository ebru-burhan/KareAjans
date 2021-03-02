using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IIncomeService : IService
    {
        List<IncomeDTO> GetComments();
        void AddComment(IncomeDTO dto);
        void DeleteComment(IncomeDTO dto);
        void UpdateComment(IncomeDTO dto);
    }
}
