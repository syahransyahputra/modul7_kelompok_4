using System;
using System.Text.Json;

public class DataMahasiswa_1302210021
{
    public void ReadJson()
    {
        string jsonString = File.ReadAllText("D:\\modul7_kelompok_4\\modul7_kelompok_4\\modul7_kelompok_4\\jurnal7_1_1302210021.json");

        Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

        Console.WriteLine(mahasiswa.firstName, mahasiswa.lastName, mahasiswa.gender, mahasiswa.age, 
            mahasiswa.address.streetAddress, mahasiswa.address.city, mahasiswa.address.state,
            mahasiswa.courses.code, mahasiswa.courses.name);
    }

    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public Courses courses { get; set; }
        public Mahasiswa() { }
        public Mahasiswa(string firstName, string lastName, string gender, int age, Address address, Courses courses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
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
        public string country { get; set; }
        public Address() { }
        public Address(string streetAddress, string city, string state)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
        }
    }

    public class Courses
    {
        public string code { get; set;}
        public string name { get; set;}
        
    }

}
