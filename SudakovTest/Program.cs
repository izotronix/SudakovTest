using System;
using LibraryLib;
namespace SudakovTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryFunctions library = new LibraryFunctions();

            Console.WriteLine("=== ТЕСТИРОВАНИЕ БИБЛИОТЕКИ ===\n");

            Console.WriteLine($"1. Название библиотеки: {library.GetLibraryName()}");

            Console.WriteLine($"2. Главный библиотекарь: {library.GetChiefLibrarian()}");

            Console.WriteLine("\n3. Список сотрудников:");
            foreach (var staffMember in library.GetStaff())
            {
                Console.WriteLine($"   - {staffMember}");
            }

            Console.WriteLine("\n4. Добавляем нового сотрудника 'Смирнов А.А.'");
            library.AddStaff("Смирнов А.А.");
            Console.WriteLine("   Обновленный список сотрудников:");
            foreach (var staffMember in library.GetStaff())
            {
                Console.WriteLine($"   - {staffMember}");
            }

            Console.WriteLine("\n5. Пытаемся сменить главного библиотекаря на 'Петров П.С.' (он есть в списке):");
            bool isChanged = library.SetChiefLibrarian("Петров П.С.");
            Console.WriteLine($"   Успешно изменено? {isChanged}");
            Console.WriteLine($"   Новый главный библиотекарь: {library.GetChiefLibrarian()}");

            Console.WriteLine("\n   Пытаемся сменить на 'Неизвестный В.В.' (его нет в списке):");
            bool isChangedFail = library.SetChiefLibrarian("Неизвестный В.В.");
            Console.WriteLine($"   Успешно изменено? {isChangedFail}");
            Console.WriteLine($"   Главный библиотекарь остался прежним: {library.GetChiefLibrarian()}");

            Console.WriteLine("\n6. Генерация кода книги:");
            string code1 = library.GenerateBookCode("FANTASY", 123);
            string code2 = library.GenerateBookCode("SCIENCE", 456);
            Console.WriteLine($"   Книга 1: {code1}");
            Console.WriteLine($"   Книга 2: {code2}");

            Console.WriteLine("\n=== ТЕСТИРОВАНИЕ ЗАВЕРШЕНО ===");
            Console.ReadKey();
        }
    }
}