using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
    public class Person
    {
        private String name;
        private String lastName;
        private int age;
        private int semester;
        private String career;

        public Person(String name, String lastName, String career, int age, int semester)
        {
            this.name = name;
            this.lastName = lastName;
            this.career = career;
            this.age = age;
            this.semester = semester;
        }

        public String Name { get {
                return name;
            }
            set { }
        }
        public String LastName {
            get
            {
                return lastName;
            }
            set { }
        }
        public int Age {
            get
            {
                return age;
            }
            set { }
        }
        public int Semester {
            get
            {
                return semester;
            }
            set { }
        }
        public String Career {
            get
            {
                return career;
            }
            set { }
        }

    }
}
