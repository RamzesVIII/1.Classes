using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Book
    {
        //Создаем 3 закрытых поля только для чтения
        private readonly Author author;
        private readonly Title title;
        private readonly Content content;

        //Инициализируем значения полей значениями аргументов
        public Book(string author, string title, string content)
        {
            this.author = new Author(author);
            this.title = new Title(title);
            this.content = new Content(content);
        }

        //Вызываем методы классов (Author, Title и Content)
        public void ShowAll()
        {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
