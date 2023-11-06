using DelegetExam.Models;
using System.Data;

namespace DelegetExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> list= new List<Exam>();
            
           


           
            while (true)
            {
                Console.WriteLine("For exam enter information,for log out q; ");


                Console.WriteLine("Enter to name: ");
                string studentName = Console.ReadLine();
                if (studentName == "q") break;


                Console.WriteLine("Enter to subject: ");
                string subject = Console.ReadLine();


                Console.WriteLine("Enter to point: ");
                int point = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter to start time(yyyy-MM-dd): ");
                DateTime startDate = DateTime.Parse(Console.ReadLine());


                Console.WriteLine("Enter to end time(yyyy-MM-dd): ");
                DateTime endTime = DateTime.Parse(Console.ReadLine());

                Exam exam = new Exam
                {
                    Student = studentName,
                    Subject = subject,
                    Point = point,
                    StartDate = startDate,
                    EndDate = endTime



                };
                list.Add(exam);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Exam results above 50 points");
            var result = list.FindAll(x => x.Point > 50);
            foreach (var x in result)

            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------------------------------------------------");
            var DurationExams = list.FindAll(e => e.Duration >= 1);
            Console.WriteLine("1 hours");
            foreach(var e in DurationExams)
            {
                Console.WriteLine(e);
            }



















            //pointi 50-den cox olan  examlarin siyahisini gosterirsiniz
            //var result = list.FindAll(x => x.Point > 50);
            //foreach(var x in result)
            //{
            //    Console.WriteLine(x);
            //}




        }
    }
}