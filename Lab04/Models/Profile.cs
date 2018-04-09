using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class Profile
    {

        public string Name;
        public string Email;
        public string Bio;
        public int Number;

        public Profile(int a)
        {
            Name = LoremNET.Lorem.Words(2);
            Email = LoremNET.Lorem.Email();
            Bio = LoremNET.Lorem.Paragraph(5, 6, 4, 10);
            Number = a;
        }
    }
}
