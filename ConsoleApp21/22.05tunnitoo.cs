using System;

namespace Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapper");

            Employee emp = new Employee();
            emp.Id = 11;
            emp.Name = "Name1";
            emp.Title = "Title1";
            emp.Description = "Description1";

            //dto t'hendab data transfer object
            EmployeeDto dto = new EmployeeDto();
            //algab mappimine

            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.Title = emp.Title;
            dto.Description = emp.Description;

            Console.WriteLine(dto.Id + " " + dto.Name);

        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }

    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
}


namespace Inheritance
{
    namespace Inheritance
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Insert two numbers: ");

                // Küsime kasutajalt esimest numbrit ja teisendame selle täisarvuks
                Console.WriteLine("First number: ");
                int firstNr = Convert.ToInt32(Console.ReadLine());

                // Küsime kasutajalt teist numbrit ja teisendame selle täisarvuks
                Console.WriteLine("Second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                // Loome Rectangle objekti
                Rectangle rectangle = new();

                // Määrame Rectangle objekti kõrguse esimese numbri väärtuseks
                rectangle.SetHeight(firstNr);

                // Määrame Rectangle objekti laiuse teise numbri väärtuseks
                rectangle.SetWidth(secondNumber);

                // Kuvame Rectangle objekti pindala
                Console.WriteLine("Total area: {0}", rectangle.GetArea());
            }
        }

        // Shape klass, mida Rectangle klass pärib
        class Shape
        {
            // Määrame laiuse
            public void SetWidth(int w)
            {
                width = w;
            }

            // Määrame kõrguse
            public void SetHeight(int h)
            {
                height = h;
            }

            // Kaitstud laiuse ja kõrguse väljad
            protected int width;
            protected int height;
        }

        // Rectangle klass, mis pärineb Shape klassist
        class Rectangle : Shape
        {
            // Arvutab ja tagastab pindala
            public int GetArea()
            {
                return (width * height);
            }
        }
    }
}
