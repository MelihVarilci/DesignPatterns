Console.WriteLine("Veritabanı veya Dosyaya bilgi kaydetme uygulamasına hoş geldin. :)\n" +
    "Kullanmak istediğiniz loglama teknolojisini seçiniz:\n" +
    "1 - Log4Net\n" +
    "2 - SeriLog");

int databaseTechnology = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Şimdi ise kaydı nereye yapmak istediğinizi seçin. :)\n" +
    "1 - File\n" +
    "2 - Database");

int recordType = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Son olarak kayıt etmek istediğiniz mesaj bilginizi girin. :)");

string message = Console.ReadLine() ?? "Melih VARILCI";

if (databaseTechnology == 1 && recordType == 1)
{
    var log4NetToFile = new FileLogger(new Log4Net());
    log4NetToFile.Log(message);
}
else if (databaseTechnology == 1 && recordType == 2)
{
    var log4NetToDatabase = new DatabaseLoger(new Log4Net());
    log4NetToDatabase.Log(message);
}
else if (databaseTechnology == 2 && recordType == 2)
{
    var seriLogToFile = new FileLogger(new SeriLog());
    seriLogToFile.Log(message);
}
else if (databaseTechnology == 2 && recordType == 1)
{
    var seriLogToDatabase = new DatabaseLoger(new SeriLog());
    seriLogToDatabase.Log(message);
}
else
{
    Console.WriteLine("Yanlış tuşlama yapmış olabilirsin :(");
}

Console.ReadLine();