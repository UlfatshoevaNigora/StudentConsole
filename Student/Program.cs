using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        StudentManager manager = new StudentManager();

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Добавить студента");
            Console.WriteLine("2. Удалить студента");
            Console.WriteLine("3. Найти студента по имени");
            Console.WriteLine("4. Показать всех студентов");
            Console.WriteLine("5. Выйти");
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Введите имя студента: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите возраст студента: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Введите оценку студента: ");
                    double grade = double.Parse(Console.ReadLine());

                    manager.AddStudent(new Student { Name = name, Age = age, Grade = grade });
                    Console.WriteLine("Студент добавлен.");
                    break;

                case "2":
                    Console.Write("Введите имя студента для удаления: ");
                    string nameToRemove = Console.ReadLine();
                    manager.RemoveStudent(nameToRemove);
                    break;

                case "3":
                    Console.Write("Введите имя студента для поиска: ");
                    string nameToFind = Console.ReadLine();
                    Student student = manager.FindStudent(nameToFind);
                    if (student != null)
                    {
                        Console.WriteLine(student);
                    }
                    else
                    {
                        Console.WriteLine("Студент не найден.");
                    }
                    break;

                case "4":
                    manager.DisplayAllStudents();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                    break;
            }
        }
    }
}
