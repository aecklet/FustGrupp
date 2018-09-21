using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace rednit.Domain
{
    class User
    {
        string uid = Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string PrefGender { get; set; }

        public User(string firstName, string gender, int age, string prefGender)
        {
            FirstName = firstName;
            Gender = gender;
            Age = age;
            PrefGender = prefGender;
        }
    }
}
