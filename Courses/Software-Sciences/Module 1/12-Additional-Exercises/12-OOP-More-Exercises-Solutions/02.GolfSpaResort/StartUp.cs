using System;

namespace GolfSpaResort
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countMember = 0;


            while (input != "End")
            {
                string[] personInfo = input.Split();
                string firstName = personInfo[0];
                string lastName = personInfo[1];

                if (personInfo.Length == 2)
                {
                    Guest guest = new Guest(firstName, lastName);
                    Console.WriteLine(guest.NewGuest());
                }
                else if (personInfo.Length == 3)
                {
                    int membershipId = int.Parse(personInfo[2]);
                    countMember++;
                    string freeAccess = "spa";
                    if (countMember % 2 == 0)
                    {
                        freeAccess = "fitness";
                    }

                    Member member = new Member(firstName, lastName, membershipId);

                    Console.WriteLine(member.GetMemberCard(freeAccess));
                }
                else if (personInfo.Length == 4)
                {
                    string department = personInfo[2];
                    int employeeId = int.Parse(personInfo[3]);
                    Employee employee = new Employee(firstName, lastName, department, employeeId);
                    Console.WriteLine(employee.StartWorkingDay());
                }

                input = Console.ReadLine();
            }
        }
    }
}
