using System;
using System.Collections.Generic;

namespace ClassLibrary5
{
    public class Student
    {
        public static List<Student> ListStudent = new List<Student>();
        private static int id = 0;
        private string FIO;
        private string Group;
        private DateTime DataBorn;
        public int IDStudent;

        public Student(string FIO, string Group, DateTime DataBorn)
        {
            this.FIO = FIO;
            this.Group = Group;
            this.DataBorn = DataBorn;
            IDStudent = id += 1;
        }

        public static void AddStudent(Student student)
        {
            ListStudent.Add(student);
        }

        public static void EditStudent(string FIO, string Group, DateTime DataBorn, int id)
        {
            bool studentExist = false;
            for (int i = 0; i < ListStudent.Count; i++)
            {
                if (i == id)
                {
                    ListStudent[i].FIO = FIO;
                    ListStudent[i].Group = Group;
                    ListStudent[i].DataBorn = DataBorn;
                    studentExist = true;
                    break;
                }
            }
            if (studentExist == false)
            {
                Console.WriteLine("Неверно указан id");
            }
        }

        public static void DeleteStudent(int id)
        {
            bool DeleteStudent = false;
            foreach (Student student in ListStudent)
            {
                if (student.IDStudent == id)
                {
                    ListStudent.Remove(student);
                    DeleteStudent = true;
                    break;
                }
            }
            if (DeleteStudent == false)
            {
                Console.WriteLine("Неверно указан id");
            }
        }

        public static void DeleteAllStudent()
        {
            int i = 1;
            if (ListStudent == null)
            {
                Console.WriteLine("Студентов нет");
            }
            else
            {
                foreach (Student student in ListStudent)
                {
                    Console.WriteLine(i++ + ". ФИО: " + student.FIO);
                }
            }

        }

        public static void ExitID(int id)
        {
            bool studentExist = false;
            foreach (Student student in ListStudent)
            {
                if (student.IDStudent == id)
                {
                    Console.WriteLine("ФИО: " + student.FIO + "\nГруппа: " + student.Group + "\nДата рождения: " + student.DataBorn.ToString().Substring(0, 10) + "\nId студента: " + student.IDStudent);
                    studentExist = true;
                    break;
                }
            }
            if (studentExist == false)
            {
                Console.WriteLine("Неверно указан id");
            }
        }

        public static void ExitHeight(int id)
        {
            bool studentExist = false;
            foreach (Student student in ListStudent)
            {
                if (student.IDStudent == id)
                {
                    var Date = DateTime.Now;
                    var Year = Date.Year - student.DataBorn.Year;
                    if (Date.Month < student.DataBorn.Month || (Date.Month == student.DataBorn.Month && Date.Day > student.DataBorn.Day))
                    {
                        Year -= 1;
                    }
                    Console.WriteLine("ФИО:" + student.FIO + "\nВозраст студента: " + Year);
                    studentExist = true;
                    break;
                }
            }
            if (studentExist == false)
            {
                Console.WriteLine("Неверно указан id");
            }
        }

        public int HeightStudent(int id)
        {
            int Year = 0;
            foreach (Student student in ListStudent)
            {
                if (student.IDStudent == id)
                {
                    var Date = DateTime.Now;
                    Year = Date.Year - student.DataBorn.Year;
                    if (Date.Month < student.DataBorn.Month || (Date.Month == student.DataBorn.Month && Date.Day > student.DataBorn.Day))
                    {
                        Year -= 1;
                    }
                }
            }
            return Year;
        }
    }
}