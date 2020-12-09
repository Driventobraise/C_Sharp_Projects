using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Assignment
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }
        public void Quit()
        {
            Console.WriteLine("2 weeks Baabyy!!");
            Console.ReadLine();
        }
    }
}
