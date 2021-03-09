using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Concretes
{
    public class AccountingManager : IAccountingService
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IOrganizationService _organizationService;

        private readonly IExpenseService _expenseService;

        public AccountingManager(IOrganizationRepository organizationRepository, IOrganizationService organizationService, IExpenseService expenseService)
        {
            _organizationRepository = organizationRepository;
            _organizationService = organizationService;

            _expenseService = expenseService;
        }


        
        public List<AccountingDTO> GetAccountingWithIncludes()
        {

            throw new NotImplementedException("");
            /*
            //totalIncome erişiliyor, başlama bitişe erişilir ordan gün saysı, Lokal mı erişilir
            //bu methoda mdelemployee organization eklersek include oalrak  hangi organizasyon da hangi manken erişilr yada başka method oluştr??
            List<OrganizationDTO> organizationDtoList = _organizationService.GetOrganizationsWithIncomes();
            */


            /*
            //mankenin maaşına erişeblrz yemek knaklama giderleri ekleyebilirz
           List<ExpenseDTO> expenseDtoList = _expenseService.GetExpenseWithExpenseType();
            */ 


            // TODO: sepet mantığını oturt AccountingDto sepet , accountingıtemdto eklenenler

        }
    }
}
