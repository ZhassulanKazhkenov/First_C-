﻿using Base.PersonTypes; // подключение пространства имен Base.PersonTypes для класса Person

Base.OrganisationTypes.Company microsoft = new("Microsoft");
Person tom = new("Tom", microsoft);
tom.Print();     // Имя: Tom   Название компании: Microsoft

namespace Base
{
    namespace PersonTypes
    {
        class Person
        {
            string name;
            OrganisationTypes.Company company;
            public Person(string name, OrganisationTypes.Company company)
            {
                this.name = name;
                this.company = company;
            }
            public void Print()
            {
                Console.WriteLine($"Имя: {name} ");
                company.Print();
            }
        }
    }
    namespace OrganisationTypes
    {
        class Company
        {
            string title;
            public Company(string title) => this.title = title;
            public void Print() => Console.WriteLine($"Название компании: {title}");
        }
    }
}