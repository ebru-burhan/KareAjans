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
    public class AccountingManager : IAccountingService
    {
        private readonly IOrganizationService _organizationService;
        private readonly IExpenseService _expenseService;
        private readonly IModelEmployeeService _modelEmployeeService;
        private readonly IModelEmployeeOrganizationRepository _modelEmployeeOrganizationRepository;
        private readonly IMapper _mapper;

        public AccountingManager(IOrganizationService organizationService, IExpenseService expenseService, IModelEmployeeService modelEmployeeService,
            IModelEmployeeOrganizationRepository modelEmployeeOrganizationRepository,
            IMapper mapper)
        {           
            _organizationService = organizationService;
            _expenseService = expenseService;
            _modelEmployeeService = modelEmployeeService;

            _modelEmployeeOrganizationRepository = modelEmployeeOrganizationRepository;
            _mapper = mapper;
        }

        public AccountingDTO GetAccountingByOrganization(int id)
        {

            /*
            //mankenin maaşına erişeblrz yemek knaklama giderleri ekleyebilirz
            List<ExpenseDTO> expenseDtoList = _expenseService.GetExpenseWithExpenseType();
            */


            //totalIncome erişiliyor, başlama bitişe erişilir ordan gün saysı, Lokal mı erişilir
            //bu methoda mdelemployee organization eklersek include oalrak  hangi organizasyon da hangi manken erişilr yada başka method oluştr??
            // List<OrganizationDTO> organizationDtoList = _organizationService.GetOrganizationsWithIncomes();


            //id sine göre organizaitoDto yu income ile getirdik
            // TODO: modelemployeeorganiztionu include et
            OrganizationDTO organizationDTO = _organizationService.GetOrganizationById(id, true);
            TimeSpan organizationTimeSpan = organizationDTO.EndingDate - organizationDTO.StartingDate;
            

           IQueryable<ModelEmployeeOrganization> modelEmployeOrganizations = _modelEmployeeOrganizationRepository.Get(x => x.OrganizationId == id, x => x.ModelEmployee);

            //foreachle herbir meo içindeki mankenlri liste koyduk bir organizasyondaki mankenler listesi
            List<ModelEmployeeDTO> modelEmployeeDtoList = new List<ModelEmployeeDTO>();
            
            

            foreach (var modeleEmployeeOrganization in modelEmployeOrganizations)
            {
                //id li modelEMployeleri getirt model employeeden dtoya çevir dtoliste ver
                // modeleEmployeeOrganization.ModelEmployeeId 
                var modelEmployee = _modelEmployeeService.GetModelEmployeeById(modeleEmployeeOrganization.ModelEmployeeId);

                modelEmployeeDtoList.Add(_mapper.Map<ModelEmployeeDTO>(modelEmployee));
            }


            AccountingDTO accountingDto = new AccountingDTO()
            {

            };

            List<AccountingItemDTO> AccountingItemList = new List<AccountingItemDTO>();
            AccountingItemDTO AccountingItemDto = new AccountingItemDTO()
            {
                ModelEmployeeName = "",
                IsLocal = organizationDTO.IsLocal,
                NumberOfDays = organizationTimeSpan.Days

            };

            return accountingDto;
        }
    }
}
