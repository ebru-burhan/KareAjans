using KareAjans.Model.ProjectBaseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IExpenseTypeService : IService
    {
        List<ExpenseTypeDTO> GetComments();
        void AddComment(ExpenseTypeDTO dto);
        void DeleteComment(ExpenseTypeDTO dto);
        void UpdateComment(ExpenseTypeDTO dto);
    }
}
