// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

using OOP3;

IKrediManager IhtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabeseLoggerService();
ILoggerService fileLogerService = new FileLoggerService();


BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(tasitKrediManager , fileLogerService);

List<IKrediManager> krediler = new List<IKrediManager> { IhtiyacKrediManager 
, tasitKrediManager};

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);