﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace TransactionGenerator.Models
{
    public class CarEvent
    {
        public string vin { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public int outsideTemperature { get; set; }
        public int engineTemperature { get; set; }
        public int speed { get; set; }
        public int fuel { get; set; }
        public int engineoil { get; set; }
        public int tirepressure { get; set; }
        public int odometer { get; set; }
        public int accelerator_pedal_position { get; set; }
        public bool parking_brake_status { get; set; }
        public bool brake_pedal_status { get; set; }
        public bool headlamp_status { get; set; }
        public string transmission_gear_position { get; set; }
        public bool ignition_status { get; set; }
        public bool windshield_wiper_status { get; set; }
        public bool abs { get; set; }
        public DateTime timestamp { get; set; }

        public string GetData()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}