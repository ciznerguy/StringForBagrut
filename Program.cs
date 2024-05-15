using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StringForBagrut
{
    internal class Program
    {
      
        // מחרוזת מתנהגת כמו מערך
        // הדפסת כל תו בשורה
        public static void PrintChar(string st)
        {
            for (int i = 0; i < st.Length; i++)
            {
                Console.WriteLine(st[i]);
            }
        }


        // יש לכתוב פעולה המקבלת מחרוזת ומדפיסה אותה בסדר הפוך

        // לכתוב פעולה המקבלת שתי מחרוזות ומחזירה את הארוכה יותר




        static void Main(string[] args)
        {

            string st = "I need a vaction vacation";
            Console.WriteLine("whole string " + st);
            PrintChar(st);

            ////// פעולה המשווה בין שתי מחרוזות

            //string st2 = "hello";
            //Console.WriteLine("is the other string equal "
            //+ st.Equals(st2));
            //string st3 = "hello";
            //// השוואה יחס גודל בין מחרוזות
            //Console.WriteLine("compare in length " +
            //st2.CompareTo(st));


            //// החזרת אינקס מופע ראשון של תו
            //Console.WriteLine("first index of char "
            //+ st.IndexOf('a'));

            //// חיפוש תת מחרוזת
            //Console.WriteLine("first index of string "
            //+ st.IndexOf("vac"));


            //// אינדקס מופע אחרון של תו
            //Console.WriteLine("last index of char "
            //+ st.LastIndexOf("a"));

            ////מופע אחרון של תת מחרוזת
            //Console.WriteLine("last index of string "
            //+ st.LastIndexOf("vac"));


            //// פעולה המחלצת תת מחרוזת
            //Console.WriteLine(st.Substring(9));

            ////חילוץ תת מחרוזת עם אורך
            //Console.WriteLine("sub string is "
            //+ st.Substring(2, 4));

            //// החלפת תו בתו אחר
            //Console.WriteLine("replacing a char "
            //+ st.Replace("n", "N"));


            //// הוספת מחרוזת

            //Console.WriteLine("add a string" +
            //    st.Insert(st.Length, " soon"));


            ////הסרת תת מחרוזת
            //st = "I need a vaction";
            //Console.WriteLine("remove a string " +
            //    st.Remove(6, "a vacation".Length));

            ////שינוי התחלת מילה

            //Console.WriteLine("toUpper " + st.ToUpper());

            //Console.WriteLine("toLower " + st.ToLower());

            ////בדיקה האם מחרוזת מוכלת
            //Console.WriteLine("contains " + st.Contains("need"));
        }
    }
}
