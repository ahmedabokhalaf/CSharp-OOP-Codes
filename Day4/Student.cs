using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Day4
{
    class Student
    {
        string StdName;
        int StdAge;
        int[] Grades = new int[10];
        //public int[] Grades { get; set; }
        int cntArray = 0;
        StringBuilder StdPassword;
        public string Name
        {
            set
            {
                if (value.Length < 6) StdName = "UserC#";
                else StdName = value;
            }
            get
            {
                return StdName;
            }
        }
        public int Age
        {
            set
            {
                if (value < 20) StdAge = 20;
                else StdAge = value;
            }
            get
            {
                return StdAge;
            }
        }
        public string Username
        {
            get
            {
                return Name + Age;
            }
        }
        public void SetGrades(int[] Grades)
        {
            for (int i = 0; i < Grades.Length; i++)
            {
                this.Grades[i] = Grades[i];
                cntArray++;
            }
        }
        public Student():this("UserC#",20)
        {
        }
        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }      
        public string ForgetPassword(string user)
        {
            if (Username.ToLower() == user.ToLower())
            {
                string pass = new Regex("([a-z])([A-Z])([0-9])([!@#$%^&*?]){8,}").ToString();
                StdPassword = new StringBuilder();
                Random RandomPass = new Random();
                for (int i = 0; i < 10; i++)
                { 
                    StdPassword.Append(pass[RandomPass.Next(pass.Length)]);
                }
                return "Your New Password is: " + StdPassword.ToString();
            }
            else
            {
                return "Username is Invalid";
            }
        }
        public void Print()
        {
            Console.WriteLine($"Student Info\nName: {Name}\nAge: {Age}\nGrades");
            for(int i = 0; i < cntArray; i++)
            {
                Console.Write(Grades[i] + "\t");
            }
            Console.WriteLine($"\nUsername: {Username}");
        }
    }
}
