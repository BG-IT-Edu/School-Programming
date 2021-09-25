using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIdentification> detainedId = new List<IIdentification>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                var parts = line.Split();

                string name = parts[0];

                if (parts.Length == 3)
                {
                    int age = int.Parse(parts[1]);
                    string id = parts[2];

                    detainedId.Add(new Citizen(name, age, id));
                }
                else
                {
                    string id = parts[1];
                    detainedId.Add(new Robot(name, id));
                }

            }

            string fakeId = Console.ReadLine();
            List<IIdentification> identifications = detainedId.Where(x => x.Id.EndsWith(fakeId)).ToList();

            foreach (var id in identifications)
            {
                Console.WriteLine(id.Id);
            }
        }
    }
}
