using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public interface ICheta
    {
        bool LetPlayDangerous(ICheta cheta);
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Book firstbook = new Book("Pushkin", "Farytales", "for kids");

            firstbook.ShowAll();
            

            ICheta [] arr = new ICheta[5];
            arr[0] = new Author("bb");
            arr[1] = new Author("bb");
            arr[2] = new BaseClass("bb");
            arr[3] = new Author("bb");
            arr[4] = new BaseClass("bb");

            //firstbook.LetPlay(new BaseClass("avtor"));
            //firstbook.LetPlayDangerous(new BaseClass("avtor"));

            for (int i = 0; i < arr.Length; i++)
            {
                firstbook.LetPlayDangerous(arr[i]);
            }
        }
        
    }
}
