using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Soldier> soldiers = new Dictionary<string, Soldier>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                var parts = line.Split();

                string type = parts[0];
                string id = parts[1];
                string firstName = parts[2];
                string lastName = parts[3];

                if (type == nameof(Private))
                {
                    //Private: "Private <id> <firstName> <lastName> <salary>"
                    decimal salary = decimal.Parse(parts[4]);
                    soldiers.Add(id, new Private(id, firstName, lastName, salary));
                }
                else if (type == nameof(LieutenantGeneral))
                {
                    //LieutenantGeneral: "LieutenantGeneral <id> <firstName> <lastName> <salary> <private1Id> <private2Id> … <privateNId>" where privateXId will always be an Id of a Private already received through the input.
                    decimal salary = decimal.Parse(parts[4]);
                    LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < parts.Length; i++)
                    {
                        string currentId = parts[i];
                        if (soldiers.ContainsKey(currentId))
                        {
                            lieutenantGeneral.Add((Private)soldiers[currentId]);
                        }
                    }
                    soldiers.Add(id, lieutenantGeneral);
                }
                else if (type == nameof(Engineer))
                {
                    //Engineer: "Engineer <id> <firstName> <lastName> <salary> <corps> <repair1Part> <repair1Hours> … <repairNPart> <repairNHours>" where repairXPart is the name of a repaired part and repairXHours the hours it took to repair it(the two parameters will always come paired).
                    decimal salary = decimal.Parse(parts[4]);
                    bool isValid = Enum.TryParse(parts[5], out Corps corps);
                    if (!isValid)
                    {
                        continue;
                    }
                    Engineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < parts.Length; i += 2)
                    {
                        string repairedPart = parts[i];
                        int repairedTime = int.Parse(parts[i + 1]);
                        Repair repair = new Repair(repairedPart, repairedTime);
                        engineer.Add(repair);
                    }

                    soldiers.Add(id, engineer);
                }
                else if (type == nameof(Commando))
                {
                    //Commando: "Commando <id> <firstName> <lastName> <salary> <corps> <mission1CodeName>  <mission1state> … <missionNCodeName> <missionNstate>" a missions code name, description and state will always come together.
                    decimal salary = decimal.Parse(parts[4]);
                    bool isValid = Enum.TryParse(parts[5], out Corps corps);

                    Commando commando = new Commando(id, firstName, lastName, salary, corps);

                    for (int i = 6; i < parts.Length; i += 2)
                    {
                        string missionName = parts[i];
                        bool isMissionValid = false;
                        if (isMissionValid = Enum.TryParse(parts[i + 1], out State state))
                        {
                            Missions missions = new Missions(missionName, state);
                            commando.Add(missions);
                        }
                    }

                    soldiers.Add(id, commando);
                }
                else if (type == nameof(Spy))
                {
                    //Spy: "Spy <id> <firstName> <lastName> <codeNumber>"
                    int codeNumber = int.Parse(parts[4]);
                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);
                    soldiers.Add(id, (Soldier)spy);
                }
            }

            foreach (var item in soldiers.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
