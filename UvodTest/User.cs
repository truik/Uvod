using System;
using System.Collections.Generic;
using System.Text;

namespace UvodTest
{
    class User: Item
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Days { get; set; }
        public int BorrowedTimes { get; set; }

        public override string ToString()
        {
            return ( FirstName.ToString()+" " + LastName.ToString() + ", " + Days.ToString()+" Dní");
        }
    }
}
