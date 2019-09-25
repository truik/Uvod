using System;
using System.Collections.Generic;
using System.Text;

namespace UvodTest
{
    class Equipment: Item, IBorrowable
    {
        public string Name { get; set; }

        public List<User> Users { get; set; }
        public List<User> Seznam = new List<User>();

        public void Borrow(User a)
        {
            Seznam.Add(a);
        }



        public override string ToString()
        {
            string s = "";
            foreach (User item in Seznam)
            {
                s += Name.ToString() + ": "+ item.ToString() + " \n";
            }
            return s.ToString();
        }
    }
}
