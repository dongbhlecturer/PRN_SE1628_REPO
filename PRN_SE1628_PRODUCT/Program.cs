
using static System.Console;
using Prn.Se1628;


Student[] students = new Student[] {
new Student(1,"Dong",8.5d),
new Student(2, "An", 3.5d),
new Student(3, "Thang", 9.5d),
new Student(4, "Hai", 4.5d)
};
foreach (Student s in students)
{
    WriteLine(s);
}

Array.Sort<Student>(students);
Console.WriteLine("------------------------");



foreach (Student s in students)
{
    WriteLine(s);
}
ReadLine();
