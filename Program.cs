using Intro.Business;
using Intro.DataAccess.Concretes;
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

CourseManager courseManager = new CourseManager(new DapperCourseDal());
List<Course> courses2 = courseManager.GetAll();     //courses2,veri kaynağından GetAll komutu ile geliyor.
for (int i = 0; i < courses2.Count; i++)    //Liste olunca count oluyor. Array olunca length.
{
    Console.WriteLine("Kurs İsmi ve Fiyatı : " + courses2[i].Name + " " + courses2[i].Price);  //Bu ikinci yazdığımız tarzda veri kaynağından geliyor kurslar.
}

Console.WriteLine("Kod bitti");

IndividualCustomer individualCustomer = new IndividualCustomer();
individualCustomer.Id = 1;
individualCustomer.NationalIdentity = "12345678922";
individualCustomer.FirstName = "Yağız";
individualCustomer.LastName = "Zorlu";
individualCustomer.CustomerNumber = "123456";

IndividualCustomer individualCustomer2 = new IndividualCustomer();
individualCustomer2.Id = 2;
individualCustomer2.NationalIdentity = "56478965412";
individualCustomer2.FirstName = "Metehan";
individualCustomer2.LastName = "Kaya";
individualCustomer2.CustomerNumber = "123457";

CorporateCustomer corporateCustomer = new CorporateCustomer();
corporateCustomer.Id = 3;
corporateCustomer.Name = "Kodlama.io";
corporateCustomer.CustomerNumber = "654778";
corporateCustomer.TaxNumber = "12345678987";

CorporateCustomer corporateCustomer2 = new CorporateCustomer();
corporateCustomer2.Id = 4;
corporateCustomer2.Name = "Abc";
corporateCustomer2.CustomerNumber = "654779";
corporateCustomer2.TaxNumber = "12345678985";

int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 50;  //Number2 nin yaşadığı değişim number1 i etkilemiyor.Çünkü değer tiptir int. Cevap 20 dir.
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";    

Console.WriteLine(cities2[0]);  //Cevap Adana'dır.Çünkü cities1 ve cities2 aynı adrese bakıyor. Diziler referans tiptir.

BaseCustomer[] baseCustomers = { individualCustomer, individualCustomer2, corporateCustomer, corporateCustomer2 };

//polymorphism
foreach (BaseCustomer customer in baseCustomers)
{ 
    Console.WriteLine(customer.CustomerNumber);
}

