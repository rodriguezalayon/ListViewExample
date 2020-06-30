using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewExample
{
    public class DataContext
    {
        public IList<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person{ Name = "Peter", PhoneNumber = "+5352675489"},
                new Person{ Name = "Jhon", PhoneNumber = "+5353423145"},
                new Person{ Name = "Smith", PhoneNumber = "+5352875637"},
                new Person{ Name = "Alex", PhoneNumber = "+5354326572"}
            };
        }
    }
}
