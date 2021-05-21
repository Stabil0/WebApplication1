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
    public class Position
    {
        [Display(Name = "Код должности")]
        public long ID { get; set; }
        [Display(Name = "Наименование должности")]
        public string Name_Positions { get; set; }
        [Display(Name = "Оклад")]
        public int Salary { get; set; }
        [Display(Name = "Обязанности")]
        public string Responsibilities { get; set; }
        [Display(Name = "Требования")]
        public string Requirements { get; set; }


    }
}