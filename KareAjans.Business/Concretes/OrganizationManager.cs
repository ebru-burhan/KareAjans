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
    public class OrganizationManager : IOrganizationService
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;
        public OrganizationManager(IOrganizationRepository organizationRepository, IMapper mapper)
        {
            _organizationRepository = organizationRepository;
            _mapper = mapper;
        }



        public List<OrganizationDTO> GetOrganizations()
        {
            var organizations = _organizationRepository.GetAll();
            return _mapper.Map<List<OrganizationDTO>>(organizations);
        }

        public void AddOrganization(OrganizationDTO dto)
        {
            _organizationRepository.Add(_mapper.Map<Organization>(dto));
        }

        public void DeleteOrganization(OrganizationDTO dto)
        {
            _organizationRepository.Delete(_mapper.Map<Organization>(dto));
        }

        public void UpdateOrganization(OrganizationDTO dto)
        {
            _organizationRepository.Update(_mapper.Map<Organization>(dto));
        }

        public List<OrganizationDTO> GetOrganizationsWithIncomes()
        {
            var organizations = _organizationRepository.GetIncluded(x => x.Incomes);

            List<OrganizationDTO> organizationDtoList = new List<OrganizationDTO>();
            //dtoda prop ekledik dbye gitmicek olan işlemleri yaptık uı da göstermek için
            //maplerken de yapılabiliyomuş ama daha sonra araştır?

            foreach (var organization in organizations)
            {
                decimal _totalIncome = 0;

                foreach (var income in organization.Incomes)
                {
                    _totalIncome += income.Amount;
                }

                var mappedOrganization = _mapper.Map<OrganizationDTO>(organization);
                
                mappedOrganization.TotalIncome = _totalIncome;

                organizationDtoList.Add(mappedOrganization);
            }

            return organizationDtoList;
        }
        /*
        public OrganizationDTO GetOrganizationById(int id)
        {
            var organization =  _organizationRepository.Get(x => x.OrganizationID == id).FirstOrDefault();

            return _mapper.Map<OrganizationDTO>(organization);
        }

        public OrganizationDTO GetOrganizationByIdwithIncomes(int id)
        {
            var organization = _organizationRepository.Get(x => x.OrganizationID == id , x => x.Incomes).FirstOrDefault();

            return _mapper.Map<OrganizationDTO>(organization);
        }
        */

        public OrganizationDTO GetOrganizationById(int id, bool incomeIncluded = false)
        {
            Organization organization = null;
            if (incomeIncluded)
            {
                organization = _organizationRepository.Get(x => x.OrganizationID == id, x => x.Incomes).FirstOrDefault();
                //accounting de total income için 
                decimal _totalIncome = 0;

                foreach (var income in organization.Incomes)
                {
                    _totalIncome += income.Amount;
                }

                var mappedOrganization = _mapper.Map<OrganizationDTO>(organization);
                mappedOrganization.TotalIncome = _totalIncome;
                return mappedOrganization;
            }
            else
            {
                organization = _organizationRepository.Get(x => x.OrganizationID == id).FirstOrDefault();
                return _mapper.Map<OrganizationDTO>(organization);
            }

            
        }
    }
}
