﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace SwaggerIO
{

    class Program
    {
        static void Main(string[] args)
        {
            var pet = new Swagger();

            var infopost = pet.Post();
            Console.WriteLine(infopost);
           
            
            Console.WriteLine("--------------------------------------------");

            var infoget = pet.Get(1);
            Console.WriteLine(infoget);

            


            Console.ReadKey();
        }
    }
}