    using System;
using System.Collections.Generic;
using System.Text;

namespace UvodTest
{
    interface IBorrowable
    {
        List<User> Users { get; set; }
        void Borrow(User a);
    }
}
