using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen1 = new Dosen ();
            Dosen dosen2 = new Dosen ();

            dosen1.dosen();

            Console.WriteLine("Nama   : {0}", dosen1.nama);
            Console.WriteLine("Course : {0}", dosen1.course);

            dosen2.adddosen(dosen2.nama, dosen2.Nik);

            dosen2.addcourse(dosen2.course);

            Thread.Sleep(2000);
        }
    }
}
