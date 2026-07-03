using Humanizer;

namespace TelemetrySanitizer
{
    class Strings
    {
        static void Main()
        {
            string stationID = "STATION_REDMOND_01";
            string statusMessage = "Critical_overheating_detected";
            double temperatureCelsius = 32D;
            dataSanitize(stationID, statusMessage, temperatureCelsius);



            static void dataSanitize(string stationID,string statusMessage,double temperatureCelsius)
            {
                string temperatureWarning = "";

                if (temperatureCelsius > 35D)
                {
                    temperatureWarning = ", WARNING, OVERHEATING!";
                }
                Console.WriteLine(stationID.Humanize());
                Console.WriteLine(statusMessage.Humanize());
                Console.WriteLine($"{temperatureCelsius}*C{temperatureWarning}");


            }  
        }
    }
}