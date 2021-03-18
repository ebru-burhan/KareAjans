using KareAjans.Entity.Enums;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IExpenseTypeService : IService
    {
        List<ExpenseTypeDTO> GetExpenseTypes();

        void UpdateExpenseType(ExpenseTypeDTO dto);

        ExpenseTypeDTO GetExpenseTypeByType(ExpenseTypeEnum type);
    }
}
