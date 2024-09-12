
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;

StudentManager studentManager = new StudentManager();



Student student1 = new Student()
{
    Isim = "Emirhan",
    Soyisim = "Çelik",
    Yas = 22,
    TuttuguTakim = "Fenerbahce",
    ProgramlamaDilleri = "C#,HTML,CSS,DotNet,Javascript",
    Numara = "+905345345334",
    DilBiliyormu = true,
    Semt = "Pendik",
};
Student student2 = new Student()
{
    Isim = "Abdullah",
    Soyisim = "Ornek",
    Yas = 18,
    TuttuguTakim = "Galatasaray",
    ProgramlamaDilleri = "C",
    Numara = "+905356667788",
    DilBiliyormu = true,
    Semt = "Kadikkoy",
};
Student student3 = new Student("Abuzer","Kadayif",33,"Besiktas","C","+90535564789",false,"Dolapdere");
// +905355647899 = 13 karakter

studentManager.Update(student1);
studentManager.Add(student2);
studentManager.Add(student3);
studentManager.Remove(student3);

class Student
{
    public Student()
    {

    }

    public Student(
        string isim,
        string soyisim,
        int yas,
        string tuttugu_takim,
        string programlama_dilleri,
        string numara,
        bool dil_biliyormu,
        string semt)
    {
        Isim = isim;
        Soyisim = soyisim;
        Yas = yas;
        TuttuguTakim = tuttugu_takim;
        ProgramlamaDilleri = programlama_dilleri;
        Numara = numara;
        DilBiliyormu = dil_biliyormu;
        Semt = semt;
    }
    //İsim, Soyisim, Yaş, Alan, Tuttuğu takım, bildikleri programlama dilleri, Numara, Yabancı Dil Biliyormu(bool), Semt
    public string Isim;
    public string Soyisim;
    public int Yas;
    public string TuttuguTakim;
    public string ProgramlamaDilleri;
    public string Numara;
    public bool DilBiliyormu;
    public string Semt;

    public void OgrenciYazdir()
    {
        Console.WriteLine($"Ogrencinin Adi : {Isim}");
        Console.WriteLine($"Ogrencinin Soyismi :{Soyisim}");
        Console.WriteLine($"Ogrencinin Yasi : {Yas}");
        Console.WriteLine($"Ogrencinin Tuttugu takim : {TuttuguTakim}");
        Console.WriteLine($"Ogrencinin Bildigi programlama dilleri : {ProgramlamaDilleri}");
        Console.WriteLine($"Ogrencinin Numarasi : {Numara}");
        Console.WriteLine($"Ogrencinin Dil biliyor mu : {DilBiliyormu}");
        Console.WriteLine($"Ogrencinin semti : {Semt}");
    }

    public override string ToString()
    {
        return $"Öğrenci ismi: {Isim}\nÖğrenci Soyismi: {Soyisim}\nÖğrenci Yasi: {Yas}\nÖğrenci Tuttugu takim : {TuttuguTakim}\nÖğrenci Bildigi progralmala dilleri: {ProgramlamaDilleri}\nÖğrenci numarasi : {Numara}\nÖğrenci Yabanci dil biliyor mu?: {DilBiliyormu}\nÖğrenci semti: {Semt}\n";
    }

}
class StudentManager
{
    public void Add(Student student)
    {
        if (student.Isim.Length < 2 && student.Soyisim.Length < 2)
        {
            Console.WriteLine("Ogrencinin adi ve soyadi minimum 2 karakter olmalidir!");
            return;
        }
        if (string.IsNullOrEmpty(student.ProgramlamaDilleri))
        {
            Console.WriteLine("Ogrenci en az bir adet Programlama dili bilmelidir!");
            return;
        }
        if (student.Yas < 18 || student.Yas > 35)
        {
            Console.WriteLine("Ogrenci yasi 18'den buyuk 35'den kucuk olmalidir!");
            return;
        }
        if (string.IsNullOrEmpty(student.Numara))
        {
            Console.WriteLine("Ogrenci numarasi bos olmamali!");
            return;
        }
        if (!student.Numara.StartsWith("+905"))
        {
            Console.WriteLine("Ogrenci numarasi +905 ile baslamali!");
            return;
        }
        if (student.Numara.Length < 13)
        {
            Console.WriteLine("Ogrenci numarsi eksik veya hatalidir!");
            // istenilen formatta girilmezse hata verecektir.
            // yani telefon numarası eksik olursa hatali sayilacaktir
            return;
        }
        Console.WriteLine("→    Ogrenci eklendi.");
        student.OgrenciYazdir();
        Console.WriteLine("-----------------------");

    }
    public void Remove(Student student)
    {
        Console.WriteLine("→    Ogrenci silindi!");
    }
    public void Update(Student student)
    {
        if (student.Isim.Length < 2 && student.Soyisim.Length < 2)
        {
            Console.WriteLine("Ogrencinin adi ve soyadi minimum 2 karakter olmalidir!");
            return;
        }
        if (string.IsNullOrEmpty(student.ProgramlamaDilleri))
        {
            Console.WriteLine("Ogrenci en az bir adet Programlama dili bilmelidir!");
            return;
        }
        if (student.Yas < 18 || student.Yas > 35)
        {
            Console.WriteLine("Ogrenci yasi 18'den buyuk 35'den kucuk olmalidir!");
            return;
        }
        if (string.IsNullOrEmpty(student.Numara))
        {
            Console.WriteLine("Ogrenci numarasi bos olmamali!");
            return;
        }
        if (!student.Numara.StartsWith("+905"))
        {
            Console.WriteLine("Ogrenci numarasi +905 ile baslamali!");
            return;
        }
        if (student.Numara.Length < 13)
        {
            Console.WriteLine("Ogrenci numarsi eksik veya hatalidir!");
            return;
        }
        Console.WriteLine("→    Ogrenci duzenlendi.");
        student.OgrenciYazdir();
        Console.WriteLine("-----------------------");
    }
}