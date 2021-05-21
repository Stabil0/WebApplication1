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
    public class Menu
    {
        [Display(Name = "Код блюда")]
        public long ID { get; set; }
        [Display(Name = "Объём ингридиента 1")]
        public int Volume_Ingredient_1 { get; set; }
        [Display(Name = "Время приготовления")]
        public DateTime Cooking_time { get; set; }
        [Display(Name = "Наименование блюда")]
        public string Name_dish { get; set; }
        [Display(Name = "Объём ингридиента 2")]
        public int Volume_Ingredient_2 { get; set; }
        [Display(Name = "Объём ингридиента 3")]
        public int Volume_Ingredient_3 { get; set; }

        [Display(Name = "Стоимость")]
        public int Cost { get; set; }


        [Display(Name = "Код ингридиента 1")]
        public long? Ingredient_1ID { get; set; }
        [Display(Name = "Ингридиент 1")]
        public DbSet<Warehouse> Ingredient_1 { get; set; }

        [Display(Name = "Код ингридиента 2")]
        public long? Ingredient_2ID { get; set; }
        [Display(Name = "Ингридиент 2")]
        public DbSet<Warehouse> Ingredient_2 { get; set; }

        [Display(Name = "Код ингридиента 3")]
        public long? Ingredient_3ID { get; set; }
        [Display(Name = "Ингридиент 3")]
        public DbSet<Warehouse> Ingredient_3 { get; set; }






    }
}