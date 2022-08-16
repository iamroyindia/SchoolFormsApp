using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        private string _TwitterAddress;
        public string TwitterAddress
        {
            get { return _TwitterAddress; }

            set
            {
                if(value.StartsWith("@"))
                {
                    _TwitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        public School()
        {
            Name = "Abhishek Roy";
            PhoneNumber = "xyz";
        }
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        // by adding static, we can use this method without instantiating the class
        public static float AverageThreeScores(float a, float b, float c)
        {
            var result =  (a+b+c)/3;
            return result;
        }

        public static float AverageThreeScores(int a, int b, int c) // function overloading - polymorphism
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name); // this is an object of the current class
            sb.AppendLine(this.Address);
            sb.AppendLine(this.City);
            sb.Append(",");
            sb.Append(this.State);
            sb.Append(" ");
            sb.Append(this.Zip);
            return sb.ToString();
        }
    }
}
