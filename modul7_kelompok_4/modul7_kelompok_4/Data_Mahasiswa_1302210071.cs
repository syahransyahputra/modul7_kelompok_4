using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_4
{
    public class Mahasiswa
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address  { get; set; }
        public List<courses> courses { get; set; }
        public Mahasiswa() { }
        public Mahasiswa(string firstname, string lastname, string gender, int age, Address address, List<courses> courses)
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
        public string streetaddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public Address() { }
        public Address(string streetaddress, string city, string state)
        {
            this.streetaddress = streetaddress;
            this.city = city;
            this.state = state;
        }
    }

    public class courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    internal class Data_Mahasiswa_1302210071
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("H:\\modul7_kelompok_4\\modul7_kelompok_4\\modul7_kelompok_4\\jurnal7_1_1302210071.json");

            Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine("Name : Afny Latifa");
            Console.WriteLine("Gender : " + mahasiswa.gender);
            Console.WriteLine("Age : " + mahasiswa.age);
            Console.WriteLine("Alamat Lengkap : " + mahasiswa.address.streetaddress + " " + mahasiswa.address.city + " " + mahasiswa.address.state);
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine("Kursus yang diikuti : " + mahasiswa.courses[i].code + " " + mahasiswa.courses[i].name);
            }
            
        }
    }
}
