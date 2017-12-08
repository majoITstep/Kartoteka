using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartoteka
{
    class StudentsDB
    {

        string[] PoleMien = new string [10] { "Palo","Fero","Jano","Stefan","Karol","Andrej","Jozef","Matej","Tomas","Pavol" };
        string[] PolePriezvisko = new string[10] { "Mrkvicka", "Kovac", "Tesar", "Murar", "Rybar", "Masar", "Vrabec","Janik","Mravec","Strechar"};

        public Student[] poleStudenti = new Student[10];

        public void LoadStudentov()
        {
            Random nahodneCislo = new Random();
            for (int i = 0; i< poleStudenti.Length; i++)
            {
                Student student;
                student.Meno = PoleMien [nahodneCislo.Next(10)];
                student.Priezvisko = PolePriezvisko[nahodneCislo.Next(10)];
                student.Vek = nahodneCislo.Next(15, 80);

                poleStudenti[i] = student;
            }
        }
        public bool Zorad(Student[] studenti, out Student[] ZoradPole)
        {
            bool boloTriedene = false;
            ZoradPole = (Student[])studenti.Clone();
                for (int i = 0; i < ZoradPole.Length;i++)
            {
                for (int j = 0; j < ZoradPole.Length - 1; j++)
                {
                    if (ZoradPole[j].Vek>ZoradPole[j+1].Vek)
                    {
                        Student tempStudent = ZoradPole[j + 1];
                        ZoradPole[j + 1] = ZoradPole[j];
                        ZoradPole[j] = tempStudent;
                        boloTriedene = true;
                    }
                        
                }
            }
            return boloTriedene;
        }
    }
}
