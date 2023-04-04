// See https://aka.ms/new-console-template for more information
using modul7_kelompok_4;

namespace modul7_kelompok_4
{
    public class Program
    {
        private static void Main(string[] args)
        {
            DataMahasiswa1302213052 dataMHS = new DataMahasiswa1302213052();
            dataMHS.ReadJSON();
        }
    }
}