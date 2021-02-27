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
        public UserType UserType { get; set; }


        //relations-------
        //generic için Icollection
        public virtual ICollection<User> Users { get; set; }
    }
}
