using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => new List<Pie> { 
            new Pie{PieId=1, Name="Strawberry Pie",Price=100, ShortDescription="Hello",LongDescription="World"},
            new Pie{PieId=2, Name="Vella Pie",Price=100, ShortDescription="Hello",LongDescription="World"}
        };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
