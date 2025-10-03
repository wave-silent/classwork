using System;


namespace project1
{
    internal class Taxi
    {
        //Поля
        string brand;
        string model;
        string taxi_number;

        //Свойства
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Taxi_number
        {
            get { return taxi_number; }
            set { taxi_number = value; }
        }

        //Конструкторы 
        public Taxi()
        {
            brand = "Mercedes-Benz";
            model = "AMG A-Class";
            taxi_number = "o007oo";
        }

        public Taxi(string brand, string model, string taxi_number)
        {
            this.Brand = brand;
            this.Model = model;
            this.Taxi_number = taxi_number;
        }

        //Методы 

        public override string ToString()
        {
            return "Марка: " + brand + " Модель: " + model + " Номера: " + taxi_number;
        }




    }
}
