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
        private readonly IMapper _mapper;

        public AccountingManager(IOrganizationService organizationService, IExpenseService expenseService, IModelEmployeeService modelEmployeeService, IExpenseTypeService expenseTypeService,
            IModelEmployeeOrganizationRepository modelEmployeeOrganizationRepository,
            IMapper mapper)
        {
            _organizationService = organizationService;
            _expenseService = expenseService;
            _expenseTypeService = expenseTypeService;
            _modelEmployeeService = modelEmployeeService;

            _modelEmployeeOrganizationRepository = modelEmployeeOrganizationRepository;
            _mapper = mapper;
        }

        public AccountingDTO GetAccountingByOrganization(int id)
        {
            //id sine göre organizaitoDto yu income ile getirdik
            // TODO: modelemployeeorganiztionu include et
            OrganizationDTO organizationDTO = _organizationService.GetOrganizationById(id, true);
            TimeSpan organizationTimeSpan = organizationDTO.EndingDate - organizationDTO.StartingDate;

            decimal incomeTotal = organizationDTO.TotalIncome;

            IQueryable<ModelEmployeeOrganization> modelEmployeOrganizations = _modelEmployeeOrganizationRepository.Get(x => x.OrganizationId == id, x => x.ModelEmployee);



            //foreachle herbir meo içindeki mankenlri liste koyduk bir organizasyondaki mankenler listesi
            List<AccountingItemDTO> accountingItemList = new List<AccountingItemDTO>();



            var foodDto = _expenseTypeService.GetExpenseTypeByType(ExpenseTypeEnum.Food);
            var accommodationDto = _expenseTypeService.GetExpenseTypeByType(ExpenseTypeEnum.Accommodation);


            // TODO: bir organizasyonda organizaitonexpensetotal => organizasyondaki manken sayısı * expensetotal 
           

            foreach (var modeleEmployeeOrganization in modelEmployeOrganizations)
            {
                var modelEmployeeDto = _modelEmployeeService.GetModelEmployeeById(modeleEmployeeOrganization.ModelEmployeeId, true);


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

                if (modelEmployeeDto.ProfessionalDegree.DailyWage != 0 )
                {
                    //kategori1 veya kategori 2 olablr
                }
                else
                {
                    //kategori3 olabilir
                }

                //bir mankenin bir organizasyonda harcadığı toplam para
                decimal expenseTotal = foodExpense + accommodationExpense;

               
                AccountingItemDTO accountingItemDto = new AccountingItemDTO()
                {
                    ModelEmployeeName = modelEmployeeDto.FirstName + " " + modelEmployeeDto.LastName,
                    IsLocal = organizationDTO.IsLocal,
                    NumberOfDays = organizationTimeSpan.Days,
                    ProfessionalDegreeTitle = modelEmployeeDto.ProfessionalDegree.Title,
                    FoodExpense = foodExpense,
                    AccommodationExpense = accommodationExpense,
                    ExpenseTotal = expenseTotal,
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
