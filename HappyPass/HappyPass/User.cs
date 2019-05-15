using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HappyPass
{
    public class User
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set ;}
        public string Email { get; set ;}
        public string Address { get; set; }
        public string Sex { get; set ;}
        public int NChildren { get; set; }
        public long UserID { get; set; }
    }
}
