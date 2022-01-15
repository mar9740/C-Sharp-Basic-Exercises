using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Mammal
    {
        protected int age;
        protected bool isMale;
        protected string name;

        public Mammal()
        {
            age = 0;
            isMale = false;
            name = null;
        }

        public override string ToString()
        {
            return "This is just a blank mammal";
        }

    }

    public class Tiger : Mammal
    {
        protected string type;

        public Tiger(int age, bool male, string name)
        {
            this.age = age;
            isMale = male;
            this.name = name;
            type = "Tiger";
        }

        public void changeName(string newName)
        {
            this.name = newName;
        }

        public void birthday() {
            age++;
        }

        public override string ToString()
        {
            return this.name+" is a "+type+" and is "+age+" years old";
        }
    }
}
