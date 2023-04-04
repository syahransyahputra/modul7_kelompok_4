using System;
using System.Text.Json;

namespace modul7_kelompok_4 {
    public class DataMahasiswa1302213052
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\modul7_kelompok_4\\modul7_kelompok_4\\modul7_kelompok_4\\jurnal7_1_1302213052.json");

            Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

            Console.WriteLine("Nama Mahasiswa :Nurul pratiwi");
            Console.WriteLine("Gender : " + mahasiswa.gender);
            Console.WriteLine("Age : " + mahasiswa.age);
            Console.WriteLine("Alamat lengkap : " + mahasiswa.address.city);
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine("Kursus yang diikuti : " + mahasiswa.courses[i].code + " " + mahasiswa.courses[i].name) ;
            }
           
        }
    }
    }

    public class Mahasiswa
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public address address { get; set; } 
        public List<courses> courses { get; set; }

        public Mahasiswa() { }
        public Mahasiswa(string firstname, string lastname, string gender, int age, address address, List<courses> courses)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.courses = courses;

        }
    }

    public class address
    {
        public string streetaddres { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public address() { }
        public address (string streetaddres, string city, string state)
        {
            this.streetaddres = streetaddres;
            this.city = city;
            this.state = state;
        }
    }

    public class courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }


