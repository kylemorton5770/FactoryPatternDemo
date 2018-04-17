﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Shared.Phones;

namespace Factory.Complex.Factories
{
    public class AndroidFactory : IPhoneFactory
    {
        public ICellPhone CreatePhone()
        {
            var android = new Android();
            android.CreateGmailAccount();
            android.RegisterPhoneNumber();
            android.CreateVoicemail();
            android.StartService();
            return android;
        }
    }
}