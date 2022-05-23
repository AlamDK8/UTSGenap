using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    public class Dosen
    {

        public int id;
        public string nama;
        public int Nik;
        public string gender;
        public string course;

        public void dosen()
        {
            nama = "Kamarudin, M.Kom";
            course = "Pemrograman";

            
        }

        public void adddosen(string name, int nik)
        {
           Console.WriteLine("Nama : ");
           name = Console.ReadLine();

           Console.WriteLine("NIK : ");
           nik = Convert.ToInt32(Console.ReadLine()); ;

        }

        public void addcourse (string ccourse)
        {
            Console.WriteLine("Course : ");
            ccourse = Console.ReadLine();
        }
    }
}
