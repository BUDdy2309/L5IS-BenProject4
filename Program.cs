using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenProject1
{
    class Program
    {
        static List<string> Employees = new List<string>();

        static void AddInformation()
        {
            string employeeName;
            int num;
            Console.WriteLine("How many employees do you want to add more");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            { 
                Console.WriteLine("Enter the fullname of employee:" + (i + 1));
                employeeName = Console.ReadLine();
                Employees.Add(employeeName);
            }
        }
        static void InsertInfo()
        {
            Console.WriteLine("Enter the location number");
            int loc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the firstname of the Employee");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter the lastname of the Employee");
            string lastname = Console.ReadLine();
            Employees.Insert(loc, firstname + " " + lastname);
            DisplayInformation();
        }
        static void UpdateInfo()
        {
            Console.WriteLine("List of Employees");
            DisplayInformation();
            int num1;
            Console.WriteLine("What employee do you want to update?");
            num1 = Convert.ToInt32(Console.ReadLine());
            Employees.RemoveAt(num1);
            Console.WriteLine("Enter the Firstname of the Employees");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter the Lastname of the Employees");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter the Email Address of the Employee: ");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter the Mobile number of the Employee: ");
            string Contact = Console.ReadLine();
            Console.WriteLine("Enter the Address of the Employee: ");
            string Address = Console.ReadLine();
            Employees.Insert(num1, firstname + " " + lastname);
            Console.WriteLine("Information successfully updated and look like this now");
            DisplayInformation();
        }
        static void DeleteInfo()
        {
            Console.Clear();
            Console.WriteLine("===========Delete Information===========");

            Console.WriteLine("List of Employees before Deleted");
            DisplayInformation();
            Console.WriteLine("Enter the location number to delete employee");
            int loc = Convert.ToInt32(Console.ReadLine());
            Employees.RemoveAt(loc);
            Console.WriteLine("Employee Name successfully deleted");
            Console.WriteLine("List of Employees after Delete");
            DisplayInformation();
        }
        static void SearchInfo()
        {
            Console.Clear();
            Console.WriteLine("============Search Information==============");
            Console.WriteLine("Enter the fullname of employee to search");
            string fname = Console.ReadLine();
            if (Employees.Contains(fname))
            {
                Console.WriteLine("Employee: " + fname + " is stored in location: " + Employees.IndexOf(fname));
            }
            else
            {
                Console.WriteLine("Sorry but this employee does not exist!");
            }
        }
        static void DisplayInformation()
        {
            Console.WriteLine("Information Stored are as:");
            for (int i = 0; i < Employees.Count; i++)
            {
                Console.WriteLine("Employees are: " + Employees[i]);
            }
        }
        static void Main(string[] args)
        {

            char c;
            do
            {
                Console.Clear();
                Console.WriteLine("=========== Employee Information ==========");
                Console.WriteLine("Press 1 to Add Information");
                Console.WriteLine("Press 2 to Insert Information");
                Console.WriteLine("Press 3 to Update Information");
                Console.WriteLine("Press 4 to Delete Information");
                Console.WriteLine("Press 5 to Search Information");
                Console.WriteLine("Press 6 to Display Information");
                Console.WriteLine("Enter your Chosen number");
                int choice;
                choice = Convert.ToInt32(Console.ReadLine());
                char ch;
                switch (choice)
                {
                    case 1:
                        do
                        {
                            AddInformation();
                            Console.WriteLine("Do you want to add more employees: Press 'y' for Yes or 'n' for No");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;
                    case 2:
                        do
                        {
                            InsertInfo();
                            Console.WriteLine("Do you want to insert more employees: Press 'y' for Yes or 'n' for No");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;
                    case 3:
                        do
                        {
                            UpdateInfo();
                            Console.WriteLine("Do you want to Update more employees: Press 'y' for Yes or 'n' for No");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;
                    case 4: 
                        do
                        {
                            Console.Clear();
                            DeleteInfo();
                            Console.WriteLine("Do you want to Delete more employees: Press 'y' for Yes or 'n' for No");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;
                    case 5:
                        do
                        {
                            SearchInfo();
                            Console.WriteLine("Do you want to Search information to the employees: Press 'y' for Yes or 'n' for No");
                            ch = Convert.ToChar(Console.ReadLine());
                        } while (ch == 'y');
                        break;
                    case 6:
                        DisplayInformation();
                        break;
                    default:
                        Console.WriteLine("To be Continued");
                        break;
                        
                }
                Console.WriteLine("Back to the main menu: Press 'y' for Yes");
                c = Convert.ToChar(Console.ReadLine());
            }while (c == 'y') ;
            Console.ReadKey();
        }
    }
} 
