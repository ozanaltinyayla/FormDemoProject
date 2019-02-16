using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FormDemoProject.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Ad")]
        public string FirstName { get; set; }

        [DisplayName("Soyad")]
        public string LastName { get; set; }

        [Required,StringLength(20), DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required, StringLength(20),DisplayName("Şifre")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }

        public bool IsActive { get; set; }

    }
}