using System;
using System.Collections.Generic;
using System.Text;

namespace rednit.Domain
{
    class User
    {
        public string UserID { get; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        
        public User(string firstName, string gender, int age)
        {
            FirstName = firstName;
            Gender = gender;
            Age = age;
        }
    }
}
