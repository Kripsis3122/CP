using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MysticBureau.Models
{
    public class Fact
    {
        public int id { set; get; }
        public string factName { set; get; }
        public string authorName { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string date { set; get; }
        public int categoryID { set; get; }
        public virtual Category category { set; get; }
    }
}
