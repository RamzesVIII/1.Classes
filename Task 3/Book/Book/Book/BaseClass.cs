using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class BaseClass : ICheta, IShow
    {   
        public string Field { get; set ; }
        //Виртуальное автосвойство цвета шрифта
        public virtual ConsoleColor FontColor { get; }
        //Инициализируем значение автосвойства значением аргумента
        public BaseClass(string field)
        {
            this.Field = field;
        }
        //Виртуальный метод выводит значение переданное автосвойству
        public virtual void Show ()
        {
            Console.ForegroundColor = FontColor;
            Console.WriteLine(Field);
            Console.ResetColor();
        }
        public virtual bool LetPlayDangerous(ICheta item)
        {
            try
            {
                var au2 = (Author)item;
                Console.WriteLine("true");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("false");
                return false;
            }
        }
    }
}
