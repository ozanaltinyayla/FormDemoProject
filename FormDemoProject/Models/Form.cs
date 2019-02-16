using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormDemoProject.Models
{
    public class Form
    {
        public int Id { get; set; }

        [Required,DisplayName("Form Adı")]
        public string Name { get; set; }

        [Required,DisplayName("Açıklama")]
        public string Description { get; set; }

        [DisplayName("Oluşturulma Tarihi")]
        public DateTime CreatedAt { get; set; }

        [Required,DisplayName("Oluşturan")]
        public int CreatedBy { get; set; }
        public virtual ICollection<Field> Fields { get; set; }

    }
}