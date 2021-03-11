using AutoMapper;
using KareAjans.Business.Abstract;
using KareAjans.DataAccess.Abstracts;
using KareAjans.Entity;
using KareAjans.Entity.Enums;
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
        private readonly IExpenseTypeService _expenseTypeService;
        private readonly IModelEmployeeService _modelEmployeeService;
        private readonly IModelEmployeeOrganizationRepository _modelEmployeeOrganizationRepository;
        private readonly IModelEmployeeRepository _modelEmployeeRepository;
        private readonly IMapper _mapper;

        public AccountingManager(IOrganizationService organizationService, IExpenseService expenseService, IModelEmployeeService modelEmployeeService, IExpenseTypeService expenseTypeService,
            IModelEmployeeOrganizationRepository modelEmployeeOrganizationRepository, IModelEmployeeRepository modelEmployeeRepository,
            IMapper mapper)
        {
            _organizationService = organizationService;
            _expenseService = expenseService;
            _expenseTypeService = expenseTypeService;
            _modelEmployeeService = modelEmployeeService;

            _modelEmployeeOrganizationRepository = modelEmployeeOrganizationRepository;
            _modelEmployeeRepository = modelEmployeeRepository;
            _mapper = mapper;
        }

        public AccountingDTO GetAccountingByOrganization(int id)
        {
            OrganizationDTO organizationDTO = _organizationService.GetOrganizationById(id, true);
            TimeSpan organizationTimeSpan = organizationDTO.EndingDate - organizationDTO.StartingDate;

            decimal incomeTotal = organizationDTO.TotalIncome;

            List<ModelEmployeeOrganization> modelEmployeOrganizations = _modelEmployeeOrganizationRepository.GetFilteredIncluded(x => x.OrganizationId == id, x => x.ModelEmployee, x => x.ModelEmployee.ProfessionalDegree).ToList();
            //IQuaryable geliyo fakat bağlantıları açık tutuyo ve mforeach içinde modelEmployee ile iiş yapamadık soyut sadece kullanıma hazır, firstOrdefault ile çekiyoz, kullanıyoz
            //tolist ile somutlaştırıyoz kullanıma hazır oluyo

            //foreachle herbir meo içindeki mankenlri liste koyduk bir organizasyondaki mankenler listesi
            List<AccountingItemDTO> accountingItemList = new List<AccountingItemDTO>();


            var foodDto = _expenseTypeService.GetExpenseTypeByType(ExpenseTypeEnum.Food);
            var accommodationDto = _expenseTypeService.GetExpenseTypeByType(ExpenseTypeEnum.Accommodation);

            //organizasyonda yüzdeli olan modelEmployeelerin sayısı
            int percentageModelEmployeeCount = modelEmployeOrganizations.Where(x => x.ModelEmployee.ProfessionalDegree.DailyWage == 0).Count();

            foreach (var modeleEmployeeOrganization in modelEmployeOrganizations)
            {
                var modelEmployee = modeleEmployeeOrganization.ModelEmployee;


                decimal foodExpense = 0;
                decimal accommodationExpense = 0;


                if (organizationDTO.IsLocal)
                {
                    foodExpense = (foodDto.Amount * organizationTimeSpan.Days);
                }
                else
                {
                    foodExpense = 2 * foodDto.Amount * organizationTimeSpan.Days;
                    accommodationExpense = accommodationDto.Amount * organizationTimeSpan.Days;
                }

                decimal salary = 0;
                if (modelEmployee.ProfessionalDegree.DailyWage != 0 )
                {
                    //kategori1 veya kategori 2 olablr
                    salary = modelEmployee.ProfessionalDegree.DailyWage * organizationTimeSpan.Days;
                }
                else
                {
                    //kategori3 olabilir income ın %20 sini kategori3 mankenler paylaşcak
                    salary = ((incomeTotal * modelEmployee.ProfessionalDegree.DailyPercentage) / 100) / percentageModelEmployeeCount;

                }

                //bir mankenin bir organizasyonda harcadığı toplam para
                decimal expenseTotal = foodExpense + accommodationExpense;

               
                AccountingItemDTO accountingItemDto = new AccountingItemDTO()
                {
                    ModelEmployeeName = modelEmployee.FirstName + " " + modelEmployee.LastName,
                    IsLocal = organizationDTO.IsLocal,
                    NumberOfDays = organizationTimeSpan.Days,
                    ProfessionalDegreeTitle = modelEmployee.ProfessionalDegree.Title,
                    FoodExpense = foodExpense,
                    AccommodationExpense = accommodationExpense,
                    ExpenseTotal = expenseTotal,
                    Salary = salary
                };
                accountingItemList.Add(accountingItemDto);

            }


            decimal expensesTotal = 0;
            decimal salariesTotal = 0;
            foreach (var item in accountingItemList)
            {
                expensesTotal += item.ExpenseTotal;
                salariesTotal += item.Salary;

            }

            decimal generalExpenseTotal = expensesTotal + salariesTotal;

            AccountingDTO accountingDto = new AccountingDTO()
            {
                Items = accountingItemList,
                ExpensesTotal = expensesTotal,
                SalariesTotal = salariesTotal,
                GeneralExpensesTotal = generalExpenseTotal,
                IncomeTotal = incomeTotal,
                Profit = incomeTotal - generalExpenseTotal
            };


            return accountingDto;
        }
    }
}
