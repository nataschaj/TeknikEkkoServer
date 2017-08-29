﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Teknik2
{
    class Client
    {
        public void Start()
        {
            String SendStr = "Natascha";

            using (TcpClient client = new TcpClient("localhost", 7))
            using (NetworkStream ns = client.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                sw.WriteLine(SendStr);
                sw.Flush();

                String incomingStr = sr.ReadLine();
                Console.WriteLine("Ekko Modtaget: " +  incomingStr);
            }
        }
    }
}
