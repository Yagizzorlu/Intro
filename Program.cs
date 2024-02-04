// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000.5;

bool isAuthenticated = false;   //Sisteme girilmiş mi    Bu false,sistemden gelen bir datadır.
Console.WriteLine(message1);

if(isAuthenticated == true)     //sadece isAuthenticated deseydik de == true olarak alacaktı.
{
    Console.WriteLine("Buton --> Hoş geldin Yağız");
}
else
{
    Console.WriteLine("Buton--> Sisteme Giriş Yapınız");
}

//string kredi1 = "Esnaf Kredisi";
//string kredi2 = "Taşıt Kredisi";
//string kredi3 = "İhtiyaç Kredisi";
//string kredi4 = "Konut Kredisi";
//string kredi5 = "Evlilik Kredisi";

string[] loans = { "Esnaf Kredisi", "Taşıt Kredisi", "İhtiyaç Kredisi", "Konut Kredisi", "Evlilik Kredisi" };

//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


Course course1 = new Course();
course1.Id = 1;
course1.Name = "C# Kursu";
course1.Description = ".NET 8";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java Kursu";
course2.Description = "Java 17";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python Kursu";
course3.Description = "Python 3.12";
course3.Price = 0;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine("Kurs İsmi ve Fiyatı : " + courses[i].Name + " " +  courses[i].Price);
}

CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();     //courses2,veri kaynağından GetAll komutu ile geliyor.
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine("Kurs İsmi ve Fiyatı : " + courses2[i].Name + " " + courses2[i].Price);  //Bu ikinci yazdığımız tarzda veri kaynağından geliyor kurslar.
}

Console.WriteLine("Kod bitti");
