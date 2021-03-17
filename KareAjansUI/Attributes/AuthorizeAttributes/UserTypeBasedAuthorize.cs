using KareAjans.Entity.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KareAjans.UI.Attributes.AuthorizeAttributes
{
    public class UserTypeBasedAuthorizeAttribute : TypeFilterAttribute
    {
        //typefilter içine bi paramatere alıp onu kullandığı (usertypebased athor) filtreye aktarıyo [UserTypeBasedAuthorize(UserType.Administrator)] bunu yapmayı sağlıyo
        public UserTypeBasedAuthorizeAttribute(UserType userType) : base(typeof(UserTypeBasedAuthorize))
        {
            Arguments = new object[] { userType.ToString() };
        }
    };

    public class UserTypeBasedAuthorize : IAuthorizationFilter
    {

        readonly string _usertype;

        //startup da add authorization serviceyi inject etmeyi sağlıyo user yetkisi kontrolü için
        readonly IAuthorizationService _authorizationService;

        public UserTypeBasedAuthorize(string usertype,
            IAuthorizationService authorizationService)
        {
            _usertype = usertype;
           _authorizationService = authorizationService;
        }

        //yetki kontrolü yapması gerektiğinde yani sayfa açılırkençalışır
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //Check active user policy.
            //sayfayı açmaya çalışan user _usertype yetkisine sahip mi
            var authResult = _authorizationService.AuthorizeAsync(context.HttpContext.User, _usertype);

            //başarılı ise devam
            if (authResult.Result.Succeeded)
            {
                return;
            }

            //başarısızsa hata fırlat
            context.Result = new ForbidResult();
        }
    }
}
