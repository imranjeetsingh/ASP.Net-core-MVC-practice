using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategory => new List<Category> { 
        new Category{CategoryId=1, CategoryName="Fruit pies",Description="All Fruit"},
        new Category{CategoryId=2, CategoryName="Veg pies",Description="All Fruit"}
        };
    }
}
