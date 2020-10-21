using System;

namespace _03._Raincast
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            //Create 3 patterns that will match our valid lines
            //The problem descriptions says EXACTLY in the format, which means
            //DO NOT FORGET the ^ and the $ for start and end of sentence
            string typePattern = "^Type: (Normal|Warning|Danger)$";
            string sourcePattern = "^Source: ([a-zA-Z0-9]+)$";
            string forecastPattern = "^Forecast: ([^!.,?]+)$";

            //Create a simple list that stores our valid raincasts
            List<string> raincasts = new List<string>();

            //A variable for the input
            string inputLine = string.Empty;

            //The current line we are searching, initially - "Type"
            //When we find a valid Type line, we will change it to - "Source"
            //When we find a valid Source line, we will change it to - "Forecast"
            //When we find a valid Forecast line, we will complete the Raincast, and add it to the list
            //Then we will start searching for a Type again
            string currentLine = "type";

            //The variable that will store the currentRaincast
            string currentRainCast = string.Empty;

            //The while loop which reads until the command is enter
            while ((inputLine = Console.ReadLine()) != "Davai Emo")
            {
                //A switch which will check what line we are searching for
                switch (currentLine)
                {
                    case "type":
                        //We check if the Type is valid
                        if (Regex.IsMatch(inputLine, typePattern))
                        {
                            //Only if the Type is valid, we put it in the Raincast, and we change it to Source
                            currentRainCast = $"({Regex.Match(inputLine, typePattern).Groups[1]})";
                            currentLine = "source";
                        }

                        //If it is not valid, we continue searching for a valid one
                        break;
                    case "source":
                        //We check if the Source is valid
                        if (Regex.IsMatch(inputLine, sourcePattern))
                        {
                            //Only if the type is valid, we put it in the Raincast, and we change it to Forecast
                            //Look closely ... Currently the Raincast looks like this
                            //"({raincastType}) *** ~ {raincastSource}"
                            //On the Forecast case, we will replace the "***" with the Forecast's value
                            //This will format our currentRaincast string directly into the output format
                            //And we will just print it
                            //Its a clever way
                            //We just store the variables in the output format
                            //And at the end we just print them
                            currentRainCast += " " + "***" + " ~ " + $"{Regex.Match(inputLine, sourcePattern).Groups[1]}";
                            currentLine = "forecast";
                        }

                        break;
                    case "forecast":
                        //We check if the Forecast is valid
                        if (Regex.IsMatch(inputLine, forecastPattern))
                        {
                            //Only if the type is valid, we put it in the Raincast
                            //Then we put the raincast in the array, and we start searching for a type again
                            //for the next raincast
                            //We replace the "***" with the Forecast's Value
                            //Currently the Raincast looks like this
                            //"({raincastType}) {raincastForecast} ~ {raincastSource}"
                            //Its in the right output format, we just add it to the list of valid raincasts
                            currentRainCast = currentRainCast.Replace("***",
                                Regex.Match(inputLine, forecastPattern).Groups[1].Value);
                            raincasts.Add(currentRainCast);
                            currentLine = "type";
                        }

                        break;
                }
            }

            //At the end of the loop
            //We just print all raincasts
            //Which are already in the valid output format
            //So no additional formatting is required
            foreach (var raincast in raincasts)
            {
                Console.WriteLine(raincast);
            }
        }
    }
}
