using System;


namespace project1
{
    internal class main
    {
        static void Main(string[] args)
        {
            Taxi auto1 = new Taxi();
            Taxi auto2 = new Taxi("Lambo Urus", "A-class", "p789oo");

            Console.WriteLine(auto1);
            Console.WriteLine(auto2);
        }
    }
}

/*using System;


namespace project1
{
    internal class main
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Ivan", 19, 3, true);
            Student student3 = new Student(student2);

            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);

            student3.DeleteStudent();
            string name;
            int age;
            float avg;

            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            // вызов проверки, что это число int
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите средний балл: ");
            // вызов проверки, что это число float
            avg = float.Parse(Console.ReadLine());

            Student student = new Student(name, age, avg, true);
            Console.WriteLine(student);


        }
    }
}*/

