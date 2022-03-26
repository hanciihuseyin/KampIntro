// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyackredimanager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerService = new DataBaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyackredimanager, fileloggerService);
            basvuruManager.BasvuruYap(tasitKrediManager, databaseloggerService);
            basvuruManager.BasvuruYap(konutKrediManager, databaseloggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyackredimanager, tasitKrediManager, konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}