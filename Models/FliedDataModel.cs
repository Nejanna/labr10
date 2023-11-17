using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace labr10.Models
{
    public class FliedDataModel
    {
        //Required Цей атрибут вказує на те, що цим властивостям необхідно обов'язково передати деякі значення.
        [Required(ErrorMessage = "Поле Ім'я прізвище є обов'язковим")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Поле Email є обов'язковим")]
        [EmailAddress(ErrorMessage = "Введіть коректний Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле дата консультації є обов'язковим")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Поле продукту є обов'язковим")]
        public string Product { get; set; }
    }
}
