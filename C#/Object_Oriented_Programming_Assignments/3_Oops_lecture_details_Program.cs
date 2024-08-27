using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_s_3_lecture_details
{
    class Lecturedetails
    {
        string LectureNmae;
        string SubjectName;
        string CourseName;
        int NumberofLectures;

        public void AssignValues(string LectureName, string SubjectName, string CourseName, int NumberofLectures)
        {
            this.LectureNmae = LectureName;
            this.SubjectName = SubjectName;
            this.CourseName = CourseName;
            this.NumberofLectures = NumberofLectures;

        }
        public void AddLectuerdetails()
        {
            Console.WriteLine(" ");
        }
        public void ShowValues()
        {
            Console.WriteLine("LectureName :" +LectureNmae);
            Console.WriteLine("SubjectName :" +SubjectName);
            Console.WriteLine("CourseName :" +CourseName);
            Console.WriteLine("NumberofLectures :" + NumberofLectures);
        }     
       static void Main(string[] args)
       {
         Lecturedetails obj = new Lecturedetails();
         obj.AssignValues("DNA", "Human body", "bio", 69);
         obj.ShowValues();
            Console.ReadLine();
       }
       
    }
}
