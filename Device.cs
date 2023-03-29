using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_GSM
{
    public class Device
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string SerialNumber { get; set; }
        public Device(string model, string manufacturer, string serialNumber)
        {
            Model = model;
            Manufacturer = manufacturer;
            SerialNumber = serialNumber;
        }

    }
}
