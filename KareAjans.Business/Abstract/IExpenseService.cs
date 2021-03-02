using KareAjans.Model.ProjectBaseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IExpenseService : IService
    {
        List<ExpenseDTO> GetComments();
        void AddComment(ExpenseDTO dto);
        void DeleteComment(ExpenseDTO dto);
        void UpdateComment(ExpenseDTO dto);
    }
}
