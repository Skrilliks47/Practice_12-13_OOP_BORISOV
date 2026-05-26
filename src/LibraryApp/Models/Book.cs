namespace LibraryApp.Models
{
    public class Book
    {
        // Свойства
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }
        
        // Конструктор
        public Book(int id, string title, string author, int year)
        {
            Id = id;
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = true; // Новая книга доступна
        }
        
        // Выдача книги
        public void CheckOut()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"+ Книга '{Title}' выдана");
            }
            else
            {
                Console.WriteLine($"– Книга '{Title}' уже выдана");
            }
        }
        
        // Возврат книги
        public void Return()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"+ Книга '{Title}' возвращена");
            }
            else
            {
                Console.WriteLine($"= Книга '{Title}' уже в библиотеке");
            }
        }
        
        // Вывод информации о книге
        public override string ToString()
        {
            string status = IsAvailable ? "Доступна" : "Выдана";
            return $"[{Id}] '{Title}' ({Author}, {Year}) - {status}";
        }
    }
}