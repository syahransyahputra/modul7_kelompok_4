using System.Text.Json;

using System;
using System.Net.Mail;

namespace modul7_kelompok_4
{
    public class DataMahasiswa1302213018
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\modul7_kelompok_4\\modul7_kelompok_4\\modul7_kelompok_4\\jurnal7_1_1302213018.json");

            Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine("Nama Lengkap : " + mahasiswa.firstname + " " + mahasiswa.lastname);
            Console.WriteLine("Jenis Kelamin : " + mahasiswa.gender);
            Console.WriteLine("Usia : " + mahasiswa.age);
            Console.WriteLine("Alamat Lengkap : " + mahasiswa.address.streetAddress + " " + mahasiswa.address.city + " " + mahasiswa.address.state );
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine("Kursus yang diikuti : " + mahasiswa.courses[i].name + " " + mahasiswa.courses[i].code);
            }
           
        }
    }

    public class Mahasiswa
    {
        internal object Member;

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Courses> courses { get; set; }
        public Mahasiswa() { }
        public Mahasiswa(string firstname, string lastname, string gender, int age, Address address, List<Courses> courses)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.courses = courses;
        }
    }

    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public Address() { }
        public Address(string streetAddress, string city, string state)
        {
            this.streetAddress= streetAddress;
            this.city= city;
            this.state= state;
        }
    }

    public class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}
