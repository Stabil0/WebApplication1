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
    public class Warehouse
    {
        [Display(Name = "Код ингредиента")]
        public long ID { get; set; }
        [Display(Name = "Срок годности")]
        public DateTime Shelf_life { get; set; }
        [Display(Name = "Наименование ингредиента")]
        public string Name_Ingredient { get; set; }
        [Display(Name = "Дата выпуска")]
        public string Incept_date { get; set; }
        [Display(Name = "Объём")]
        public int Volume { get; set; }
        [Display(Name = "Поставщик")]
        public string Producer { get; set; }
        [Display(Name = "Стоимость")]
        public int Cost { get; set; }

    }
}