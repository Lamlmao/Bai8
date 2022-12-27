using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai8
{
    public class Person
    {
        protected string _name;
        public string Name { get => _name; }
        protected string _address;
        public string Address { get => _address; set => _address = value; }
        protected string _gender;
        public string Gender { get => _gender; }
        protected DateTime _birth;
        public DateTime Birth { get => _birth; }

        public Person()
        {
        }
        public Person(string name, string address, string gender, DateTime birth)
        {
            _name = name;
            _address = address;
            _gender = gender;
            _birth = birth;
        }
        public int GetAge()
        {
            int age = DateTime.Now.Year - _birth.Year;
            return age;
        }
        public void Input(string name, string address, string gender, DateTime birth)
        {
            _name = name;
            _address = address;
            _gender = gender;
            _birth = birth;
        }
    }
}