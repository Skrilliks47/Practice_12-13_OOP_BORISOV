using LibraryApp.Models;
using LibraryApp.Services;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Система управления библиотекой ===\n");
            
            // Создание библиотеки
            Library library = new Library("Городская библиотека №1");
            
            // Создание сервиса
            LibraryService service = new LibraryService(library);
            
            // Добавление тестовых книг
            Console.WriteLine("Добавление книг:");
            library.AddBook("Война и мир", "Л.Н. Толстой", 1869);
            library.AddBook("Преступление и наказание", "Ф.М. Достоевский", 1866);
            library.AddBook("Мастер и Маргарита", "М.А. Булгаков", 1967);
            library.AddBook("Анна Каренина", "Л.Н. Толстой", 1877);
            library.AddBook("Идиот", "Ф.М. Достоевский", 1869);
            
            // Отображение всех книг
            library.DisplayAllBooks();
            
            // Выдача книг
            Console.WriteLine("\n=== Выдача книг ===");
            service.CheckOutBook(1);
            service.CheckOutBook(3);
            
            // Отображение доступных книг
            service.ShowAvailableBooks();
            
            // Поиск по автору
            service.SearchByAuthor("Толстой");
            
            // Возврат книги
            Console.WriteLine("\n=== Возврат книг ===");
            service.ReturnBook(1);
            
            // Статистика
            service.ShowStatistics();
            
            // Попытка выдать уже выданную книгу
            Console.WriteLine("\n=== Проверка повторной выдачи ===");
            service.CheckOutBook(3);
            
            Console.WriteLine("\nПрограмма завершена. Нажмите Enter...");
            Console.ReadLine();
        }
    }
}