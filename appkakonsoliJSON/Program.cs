using System;



namespace appkakonsoliJSON

{
    internal class Program
    {
        protected Program()
            {}
        static void Main(string[] args)
        {

            GetLocationByIP getLocation =  new GetLocationByIP();

            string ipAddress = getLocation.CheckMyIP();
            object dupa = getLocation.LocationName(ipAddress);
        }
    }
}