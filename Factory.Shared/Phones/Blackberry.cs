﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Shared.Phones
{
    public class Blackberry : ICellPhone
    {
        public void CreateVoicemail()
        {
            Console.WriteLine();
            Console.WriteLine("-> Blackberry - Voicemail Box Created!");
        }

        public void RegisterPhoneNumber()
        {
            Console.WriteLine();
            Console.WriteLine("-> Blackberry - Phone Number Registered!");
        }

        public void StartService()
        {
            Console.WriteLine();
            Console.WriteLine("-> Blackberry - Starting Service");
        }

        public void CallSomeone()
        {
            Console.WriteLine();
            Console.WriteLine("-> Hey Adam, [Insert funny line about Blackberry phones being old & stupid]. " +
                              "\n\n" +
                              "*Hold for laughter*");
        }

    }
}
