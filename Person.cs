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

        public String Name { get; set; }
        public String LastName { get; set; }
        public int Age { get; set; }
        public int Semester { get; set; }
        public String Career { get; set; }

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

        public void escritura()
        {
            try
            {

                StreamWriter sw = new StreamWriter("..\\..\\ejemplo.txt", true);

                sw.WriteLine(name + ";" + lastName + ";" + age + ";" + semester + ";" + career);

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

    }
}
