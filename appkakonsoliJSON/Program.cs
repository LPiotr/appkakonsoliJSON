using System;


namespace appkakonsoliJSON // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        protected Program()
            {}
        static void Main(string[] args)
        {
            GetLocationByIP getLocation =  new GetLocationByIP();

            string ipAddress = getLocation.CheckMyIP();
            getLocation.LocationName(ipAddress);

            
        }
    }
}