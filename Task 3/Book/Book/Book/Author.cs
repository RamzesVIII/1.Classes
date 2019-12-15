using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Author : BaseClass
    {
        //Переопределяем свойство новым значением цвета шрифта
        public override ConsoleColor FontColor => ConsoleColor.Magenta;
        //Вызываем консруктор базового класса
        public Author (string author) : base (author)
        {
            
        }
        //public Author() { }
        //Переопределяем метод базового класса
        public override void Show() 
        {
            base.Show();
        }

    }
}
