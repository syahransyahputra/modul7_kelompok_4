using modul7_kelompok_4;
using System;
using System.Text.Json;

public class TeamMembers1302213018
{
    public void ReadJSON()
    {
        String jsonString = File.ReadAllText("D:\\modul7_kelompok_4\\modul7_kelompok_4\\modul7_kelompok_4\\jurnal7_2_1302213018.json");

        Member MHS = JsonSerializer.Deserialize<Member>(jsonString);

        
        for (int i = 0; i < 4;i++)
        {
            Console.WriteLine("Nama Lengkap : " + MHS.member[i].firstname + " " + MHS.member[i].lastname);
            Console.WriteLine("Jenis Kelamin : " + MHS.member[i].gender);
            Console.WriteLine("Usia : " + MHS.member[i].age);
            Console.WriteLine("NIM : " + MHS.member[i].nim);
        }

    }

    public class Member
    {
        public List<Members> member { get; set; }
        public Member() { }
        public Member(List<Members> member)
        {
            this.member = member;
        }
        public class Members
        {
            public string firstname;
            public string lastname;
            public string gender;
            public int age;
            public int nim;
        }

    }

}
