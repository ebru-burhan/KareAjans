using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Abstract
{
    public interface IAccountingService : IService
    {
        AccountingDTO GetAccountingByOrganization(int id);
    }
}
