using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2210A_CSharp.demo3
{
    internal class CodeTeacher : Teacher, ITeacher
    {
        private int age;
        public CodeTeacher() 
        {
            
        }

        public CodeTeacher(string name, int age) : base(name)
        {
            this.age = age;
        }

        public override void Teach()
        {
            base.Lunch();
        }

        public new void Lunch() 
        {
            
        }

        public void Eat()
        {

        }
    }
}
