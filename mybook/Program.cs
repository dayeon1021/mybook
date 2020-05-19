using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyBook> list = new List<MyBook>();
            list.Add(new MyBook()
            {
                bookName = "PHP 프로그래밍 입문",
                firstDate = "2103년 5월 20일",
                writer = "황재호",
                scavenger = "한빛아카데미(주)",
                responsibility = "김현용",
                plan = "김이화",
                edit = "김이화",
                design = "여동일"
            });
        }
    }
}
