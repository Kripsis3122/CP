using MysticBureau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MysticBureau.ViewModels
{
    public class FactListViewModel
    {
        public IEnumerable<Fact> AllFacts { get; set; }

        public IEnumerable<Category> currCategory { get; set; }
    }
}
