using MysticBureau.Interfaces;
using MysticBureau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MysticBureau.Mocks
{
    public class MockFacts : IAllFacts
    {
        private readonly IFactsCategory _factCategory = new MockCategory();
        public IEnumerable<Fact> Facts
        {
            get
            {
                return new List<Fact>
                {
                    new Fact {
                        factName = "Flying orbs", 
                        authorName = "Kirill", 
                        shortDesc = "They are small, about 15 centimeters in diameter, black in color and absorb everything they touch.", 
                        longDesc = "When they absorb something they grow. They can absorb only those object that are smaller than their size. They are in the city Vekshma.", 
                        date = "2018.08.21", 
                        category = _factCategory.allCategories.Last()},
                    new Fact {
                        factName = "Fairies",
                        authorName = "ZhuZhu",
                        shortDesc = "Little creatures about 10-20 centimeters in tall, with wings.",
                        longDesc = "They like to play with people, lead them into the forests so that they cannot get out of there. They are found in all forests.",
                        date = "2020.10.15",
                        category = _factCategory.allCategories.First()},
                    new Fact {
                        factName = "Giant Centipede",
                        authorName = "Sanchez",
                        shortDesc = "Purple centipede, 40 meters tall.",
                        longDesc = "Her paws are sharp as knives, she can reach speeds of 80 km / h, all her skin is covered with bullet-proof chitin. She is in Makhachkala, if you don’t get rid of her, she will destroy all life.",
                        date = "2022.04.04",
                        category = _factCategory.allCategories.Last()}
                };
            }
        }

        public Fact getFact(int factId)
        {
            throw new NotImplementedException();
        }
    }
}
