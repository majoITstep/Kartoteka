using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartoteka
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDB databaza = new StudentsDB();
            databaza.LoadStudentov();
            Student[] zotriedeniStudenti;
            databaza.Zorad(databaza.poleStudenti, out zotriedeniStudenti);

            Console.WriteLine();

        }
    }
}
