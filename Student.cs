using System;


namespace project1
{
    internal class Student
    {
        // поля 
        string name;
        int age;
        float avg;
        bool gender;

        // свойства 
        public string Name { 
            get { return name; }
            set
            {
                if (value != "" || value != null || string.IsNullOrEmpty(value) || value != "\n")
                    name = value;
                else
                {
                    Console.WriteLine("Ошибка имени!");
                    name = "Oleg";
                }
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18)
                    age = value;
                else
                {
                    Console.WriteLine("Ошибка возраста!");
                    //while (value)  лучше организовать способ, чтобы человек заново вводил c проверкой
                    age = 20;
                }
            }
        }
        public float Avg
        {
            get { return avg; }
            set { if ((value >= 2) && (value <= 5))
                    avg = value;
            else
                {
                    Console.WriteLine("Ошибка балла!");
                    avg = 3;
                }
                 }
        }
        public bool Gender
        {
            get { return gender; }          
        }

        // Конструкторы 
        // по умолчанию 
        public Student()
        {
            name = "Oleg";
            age = 18;
            avg = 4;
            gender = true;
        }
        //копирования
        public Student(Student student)
        {
            this.name = student.Name;
            this.age = student.Age;
            this.avg = student.Avg;
            this.gender = student.Gender;
        }
        // с параметрами 
        public Student(string name, int age, float avg, bool gender)
        {
            this.Name = name;
            this.Age = age;
            this.Avg = avg;
            this.gender = gender;
        }
        
        //Методы, созданные нами
        public void DeleteStudent()
        {
            Console.WriteLine(name + " отчислен!");
        }

        // Это метод, который вызывается по умолчанию, он будет в самом конце, так как он перегруженный
        public override string ToString()
        {
            return name + " " + age + " лет " + avg + " балл " + gender;
        }


    }
}
