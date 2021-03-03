using AutoMapper;
using KareAjans.Entity;
using KareAjans.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Comment, CommentDTO>();
            CreateMap<CommentDTO, Comment>();

            CreateMap<Expense, ExpenseDTO>();
            CreateMap<ExpenseDTO, Expense>();

            CreateMap<ExpenseType, ExpenseTypeDTO>();
            CreateMap<ExpenseTypeDTO, ExpenseType>();

            CreateMap<Income, IncomeDTO>();
            CreateMap<IncomeDTO, Income>();

            CreateMap<ModelEmployee, ModelEmployeeDTO>();
            CreateMap<ModelEmployeeDTO, ModelEmployee>();

            CreateMap<ModelEmployeeOrganization, ModelEmployeeOrganizationDTO>();
            CreateMap<ModelEmployeeOrganizationDTO, ModelEmployeeOrganization>();

            CreateMap<Organization, OrganizationDTO>();
            CreateMap<OrganizationDTO, Organization>();

            CreateMap<Permission, PermissionDTO>();
            CreateMap<PermissionDTO, Permission>();

            CreateMap<Picture, PictureDTO>();
            CreateMap<PictureDTO, Picture>();

            CreateMap<ProfessionalDegree, ProfessionalDegreeDTO>();
            CreateMap<ProfessionalDegreeDTO, ProfessionalDegree>();

            CreateMap<SiteContent, SiteContentDTO>();
            CreateMap<SiteContentDTO, SiteContent>();

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
