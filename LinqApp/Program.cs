// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using LinqApp;

string[] dersler = { "Matematik", "Türkçe", "Fen Bİlgisi", "Beden Eğitimi", "Müzik", "Tarih" };
//Query Syntax;
//var dersList = from ders in dersler
//               select ders;

//var dersList = from ders in dersler
//               where ders.Contains("çe")
//               select ders;

//var dersList = from ders in dersler
//               orderby ders descending
//               select ders;

//var dersList = dersler.Take(3);
//var dersList = dersler.TakeLast(3);
//Console.WriteLine(string.Join(',', dersList));

//List<Personel> personelList = new List<Personel>()
//{
//    new Personel{ID=1,FirstName="John",LastName="Doe",Salary=25000},
//    new Personel{ID=2,FirstName="Jeyn",LastName="Doe",Salary=30000},
//    new Personel{ID=3,FirstName="Tom",LastName="Doe",Salary=20000},
//    new Personel{ID=4,FirstName="Philip",LastName="Doe",Salary=45000},
//    new Personel{ID=5,FirstName="Hans",LastName="Doe",Salary=60000}
//};
//Tüm Personeller
//var personeller = from p in personelLİst
//                  select p;
//Maaşı 30000 den büyük olanlar
//var personeller = from p in personelList
//                  where p.Salary >= 30000
//                  select p;//Query Syntax
//var personeller = personelList.Where(x => x.Salary >= 30000).OrderByDescending(x=>x.Salary);//Method Syntax
//Adı ve ya Soyadında h harfi geçen personeller
//var personeller = from p in personelList
//                  where p.FirstName.Contains("h") || p.LastName.Contains("h")
//                  orderby p.Salary descending
//                  select p;//Query Syntax
//var personeller = personelList.Where(x => x.FirstName.Contains("h") || x.LastName.Contains("h")).OrderByDescending(x => x.Salary);//Method Syntax

//foreach (var personel in personeller)
//{
//    Console.WriteLine($"PersonelID : {personel.ID}\n");
//    Console.WriteLine($"Personel Adı : {personel.FirstName} {personel.LastName}\n");
//    Console.WriteLine($"Personel Maaş : {personel.Salary}");
//    Console.WriteLine();
//    Console.WriteLine(new string('*', 100));
//    Console.WriteLine();
//}

//IList<Student> studentList = new List<Student>()
//{
//    new Student{StudentID=1,Name="John Doe",Age= 22},
//    new Student{StudentID=2,Name="Jeyn Doe",Age= 25},
//    new Student{StudentID=3,Name="Tom Doe",Age= 20},
//    new Student{StudentID=4,Name="Bill Doe",Age= 18},
//    new Student{StudentID=5,Name="Bob Doe",Age= 27}
//};
//Tüm Öğrenciler
//Query Syntax
//var students = from student in studentList
//               select student;
//Method Syntax
//var students = studentList.ToList();

//Belirli property - kolonlorı almak için. StudentID ve Name alanları listelensin
//QUery Syntax
//var students = from student in studentList
//               select new
//               {
//                   student.StudentID,
//                   student.Name
//               };
//Method Syntax
//var students = studentList.Select(x => new { x.StudentID, x.Name });
////foreach (var student in students)
////    Console.WriteLine($"Student ID : {student.StudentID} - Name : {student.Name} - Age : {student.Age}");

//foreach (var student in students)
//    Console.WriteLine($"Student ID : {student.StudentID} - Name : {student.Name}");