﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configurator.Model
{
    public class Device
    {
        public string Name { get; set; }
        public string TypeDevice { get; set; }
        public string Type { get; set; }
        public int Port { get; set; }
        public int Addres { get; set; }

        public Device(string name, string typeDev, string type, int port, int addres) 
        {
            Name = name;
            TypeDevice = typeDev;
            Type = type;
            Port = port;
            Addres = addres;

        }
    }
}
