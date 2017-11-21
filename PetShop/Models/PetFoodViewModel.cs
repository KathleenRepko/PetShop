using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop.Models
{
    public class PetFoodViewModel
    {
        public Pet pet { get; set; }
        public ICollection<Food> foods { get; set; }


    }
}