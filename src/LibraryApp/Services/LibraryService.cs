using System;
using LibraryApp.Models;

namespace LibraryApp.Services
{
    public class LibraryService
    {
        private Library library;
        
        // Конструктор
        public LibraryService(Library library)
        {
            this.library = library;
        }
        
        // Выдача книги по ID
        public void CheckOutBook(int id)
        {
            Book? book = library.FindBookById(id);
            if (book == null)
            {
                Console.WriteLine($"Книга с ID {id} не найдена");
                return;
            }
            book.CheckOut();
        }
        
        // Возврат книги по ID
        public void ReturnBook(int id)
        {
            Book? book = library.FindBookById(id);
            if (book == null)
            {
                Console.WriteLine($"Книга с ID {id} не найдена");
                return;
            }
            book.Return();
        }
        
        // Поиск книг по автору
        public void SearchByAuthor(string author)
        {
            var books = library.FindBooksByAuthor(author);
            Console.WriteLine($"\nПоиск книг автора: {author}");
            if (books.Count == 0)
            {
                Console.WriteLine("Книги не найдены");
                return;
            }
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
        
        // Показать доступные книги
        public void ShowAvailableBooks()
        {
            var availableBooks = library.GetAvailableBooks();
            Console.WriteLine("\nДоступные книги:");
            if (availableBooks.Count == 0)
            {
                Console.WriteLine("Нет доступных книг");
                return;
            }
            foreach (var book in availableBooks)
            {
                Console.WriteLine(book);
            }
        }
        
        // Показать статистику
        public void ShowStatistics()
        {
            int total = library.GetBookCount();
            int available = library.GetAvailableBooks().Count;
            int checkedOut = total - available;
            Console.WriteLine("\n=== Статистика ===");
            Console.WriteLine($"Всего книг: {total}");
            Console.WriteLine($"Доступно: {available}");
            Console.WriteLine($"Выдано: {checkedOut}");
        }
    }
}