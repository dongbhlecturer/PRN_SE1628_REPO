using System;
using System.Text;
using System.Collections;

using static System.Console;
/*namespace for .NET 6*/
namespace FPTEDU.PRN.SE1628;
//namespace city.district.ward.street; //path vs location same as package in Java


public class Program
{
    public static void Main(string[] args)
    {
        /*1. create a object Student*/
        //Init-only Properties
        Student s = new Student { MarkAvg = 8.0d };
        WriteLine(s);
      
       


        /*2. create a array list more Student and display them*/
        ArrayList lstStudent = new ArrayList();//constructor no params

        lstStudent.Add(new Student(1,"Dong",8.4,new Address(493,"CMT8","P.13","Quan 10","HCMC")));
        lstStudent.Add(new Student(2, "Binh", 5.4, new Address(134, "Nguyen Thai Binh", "P.Ben Nghe", "Quan 1", "HCMC")));
        lstStudent.Add(new Student(3, "Long", 6.4, new Address(22, "Hung Vuong", "P.13", "Quan 10", "HCMC")));
        lstStudent.Add(new Student(4, "Hai", 8.5, new Address(12, "Vo Nguyen Giap", "P.13", "Quan 10", "HCMC")));
        lstStudent.Add(new Student(5, "Than", 9.3, new Address(43, "Pham Hung", "P.13", "Quan 10", "HCMC")));
        Display(lstStudent);

        ReadLine();
    }


    private static void Display(ArrayList lstData)
    {
        foreach (Student s in lstData)
        {
            WriteLine(s);
        }
    }
   
}
