using System;
using System.Collections.Generic;
using System.Text;

namespace KareAjans.Entity.Abstracts
{
    public interface IEntity
    {
        int ID { get; set; }
        DateTime CreatedDate { get; set; }

    }
}
