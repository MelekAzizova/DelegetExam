using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegetExam.Models
{
    public class Exam
    {
        public string Student { get; set; }
        public int Point { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public  DateTime EndDate { get; set; }

        public double Duration =>(EndDate- StartDate).TotalHours;
       

       


        public override string ToString()
        {
            return $"Student: {Student}  Point: {Point} Subject: {Subject} Duration: {Duration} ";
        }

    }
}
