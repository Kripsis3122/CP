using MysticBureau.Interfaces;
using MysticBureau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MysticBureau.Mocks
{
    public class MockCategory : IFactsCategory
    {
        public IEnumerable<Category> allCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Wolf", desc = "Any potential threat that poses a danger to an unknown degree." },
                    new Category { categoryName = "Tiger", desc = "Any threat to a large number of people." },
                    new Category { categoryName = "Demon", desc = "Any threat to a city and its people." },
                    new Category { categoryName = "Dragon", desc = "Any threat to multiple cities." },
                    new Category { categoryName = "God", desc = "A threat endangering the survival of humanity in general." }
                };
            }
        }
    }
}
