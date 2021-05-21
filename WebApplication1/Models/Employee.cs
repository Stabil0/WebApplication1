using WebApplication1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Display(Name = "Код сотрудника")]
        public long ID { get; set; }

        [Display(Name = "Фио")]
        public string FGS { get; set; }

        [Display(Name = "Возраст")]
        public int Old { get; set; }

        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        [Display(Name = "Номер телефона")]
        public int Telefon { get; set; }

        [Display(Name = "Паспортные данные")]
        public string Pasport { get; set; }
        [Display(Name = "Код должности")]
        public long? PositionsID { get; set; }
        [Display(Name = "Должность")]
        public DbSet<Position> ID_Positions { get; set; }

        ///


    }
}