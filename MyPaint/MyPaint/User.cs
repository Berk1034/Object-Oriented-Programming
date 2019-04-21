using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class User
    {
        public string Name;
        public int Age;
        public User(int age, string nm)
        {
            this.Name = nm;
            this.Age = age;
        }
        public virtual void Say()
        {
            Console.WriteLine("Hello, my name is{0} and age is {1}", Name, Age);
        }
    }
    class Hero : User
    {
        public string achievement;
        public Hero(int age, string nm, string achievement) : base(age, nm)
        {
            this.achievement = achievement;
        }
        public override void Say()
        {
            Console.WriteLine("Hello, my name is{0} and age is {1} and achievement{2}", Name, Age, achievement);
        }

        public void main()
        {
            User u = new Hero(1, "11", "1");
            u.Say();
        }
        /*
        public void goGas(Car car)
        {

        }
        */
    }
}
