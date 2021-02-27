using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KareAjans.Entity.Abstracts
{
    public abstract class BaseEntity : IEntity
    {
        // TODO: keylenecek
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
