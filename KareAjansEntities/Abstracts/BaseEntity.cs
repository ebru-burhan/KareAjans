using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KareAjans.Entity.Abstracts
{
    public abstract class BaseEntity : IEntity
    {
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
