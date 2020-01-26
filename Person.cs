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
                return name;
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

        public void lectura()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\ejemplo.txt");

                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    String[] lines = sr.ReadLine().Split(';');
                    name = lines[0];
                    lastName = lines[1];
                    age = Convert.ToInt32(lines[2]);
                    semester = Convert.ToInt32(lines[3]);
                    career = lines[4];

                }

                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
