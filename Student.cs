using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bai8
{
    public class Student : Person
    {
        protected string _id;
        public string Id { get => _id; set => _id = value; }
        protected float _point;
        public float Point { get => _point; set => _point = value; }
        protected string _email;
        public string Email { get => _email; set => _email = value; }
        public Student()
        {
        }

        public Student(string name, string address, string gender, DateTime birth, string id, float point, string email) : base(name, address, gender, birth)
        {
            _id = id;
            _point = point;
            _email = email;
        }
        
        public void CheckHoBo()
        {
            if(_point >= 8)
            {
                Console.WriteLine("Co hoc bong");
            }
            else
            {
                Console.WriteLine("Khong co hoc bong");
            }
        }
        public void OutputStudent() 
        {
            Console.WriteLine("Thong tin hoc sinh: ");
            Console.WriteLine(_name + " " + GetAge() + " " + _gender + " " + _address + " " + _birth + " " + _id + " " + _point + " " + _email);
        }
    }
}