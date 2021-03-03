using KareAjans.Entity.Abstracts;
using KareAjans.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity
{
    public class Permission : BaseEntity
    {
        // TODO: tablonun gerekli olup olmadığına ilerlerken bak gerekmezse usertype ı usera koy yapcak bişi yok dinamik olmasın istenmiyo sonuçta
        public int PermissionID { get; set; }
        public UserType UserType { get; set; }


        //relations-------
        public virtual ICollection<User> Users { get; set; }
    }
}
