﻿using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();          
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService filebaseLoggerService = new FilebaseLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() 
            {new SmsLoggerService(),new FilebaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(esnafKrediManager,loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
