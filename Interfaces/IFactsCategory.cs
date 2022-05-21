using MysticBureau.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MysticBureau.Interfaces
{
    public interface IFactsCategory
    {
        IEnumerable<Category> allCategories { get; }
    }
}
