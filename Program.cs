using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string y;
            List<Class1> classList = new List<Class1>();
            int temp = 0, NumberofStudents, i, SidToDelete;
            do
            {
               
                Console.WriteLine("PLEASE ENTER THE ACTION TO BE PERFORMED LIKE 1.ADD, 2.UPDATE, 3.DELETE,4.VIEW");
                int caseSwitch = Int32.Parse(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("please enter the number of students you want to enter");
                        NumberofStudents = Convert.ToInt32(Console.ReadLine());
                        i = 0;
                        while (i < NumberofStudents)
                        {
                            temp += 1;
                            Console.WriteLine("please enter the Sname");
                            string S1 = Console.ReadLine();
                            Console.WriteLine("please enter the Age");
                            int age = Int32.Parse(Console.ReadLine());
                            classList.Add(new Class1() { studentid = temp, Sname = S1, Age = age });
                            i++;
                        }
                        foreach (Class1 aclass in classList)
                        {
                            Console.WriteLine("Student Id:" + aclass.studentid + "\nStudent Name:" + aclass.Sname + "\nStudent Age:" + aclass.Age);
                        }
                        //Console.WriteLine(classList.Count);
                        break;

                    case 2:
                        Console.WriteLine("please enter the Studentid on which you want to perform the edit");
                        int SidToEdit = Convert.ToInt32(Console.ReadLine());
                        var obj = classList.Where(ele => ele.studentid == SidToEdit).FirstOrDefault();
                        Console.WriteLine(obj.Sname);
                        Console.WriteLine(obj.Age);

                        Console.WriteLine("Please enter which field you want to edit(sname/age)");
                        string x = Console.ReadLine();
                        switch (x.ToLower())
                        {
                            case "sname":
                                Console.WriteLine("Enter Student Name:");
                                string Sname = Console.ReadLine();
                                obj.Sname = Sname;
                                break;
                            case "age":
                                Console.WriteLine("Enter the Age:");
                                int Age =Convert.ToInt32( Console.ReadLine());
                                obj.Age = Age;
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("you choose to update the List");
                        Console.WriteLine("Please enter the ID");
                        SidToDelete=Convert.ToInt32(Console.ReadLine());

                        var abc = classList.Where(ele => ele.studentid == SidToDelete).FirstOrDefault();
                        classList.Remove(abc);  
                        if (classList.Count > 0)
                        {
                            foreach (Class1 aclass in classList)
                            {
                                Console.WriteLine("studentid is" + aclass.studentid);
                            }
                        }
                        else
                        {
                            Console.WriteLine("The List is Empty");
                        }
                        break;

                    case 4:
                        foreach (Class1 cclass in classList)
                        {
                            Console.WriteLine("Student Id:" + cclass.studentid + "\nStudent Name:" + cclass.Sname + "\nStudent Age:" + cclass.Age);
                        }
                        break;
                }
                Console.WriteLine("Press 'Y' to exit:");
                y = Console.ReadLine();
            } while (y.ToLower() != "y");
        }
    }
}
