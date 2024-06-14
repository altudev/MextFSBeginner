
using MextFSBeginner.Entities;
using MextFSBeginner.Entities.Enums;

var parent = new Parent()
{
    FirstName = "Seyda Nur",
    LastName = "Tasci",
    IdentityNumber = "1234567890",
};

var teacher = new Teacher()
{
    FirstName = "Alper",
    LastName = "Tunga",
    IdentityNumber = "123456789052"

};

var errorLog = new ErrorLog()
{
    Message = "Error Message",
    Date = DateTime.Now,
    Type = LogType.Error,
    IsImportant = true
};

Console.WriteLine(errorLog.GetLogType());

var infoLog = new InfoLog()
{
    Message = "Info Message",
    Date = DateTime.Now,
    Type = LogType.Info,
    IsImportant = false
};

Console.WriteLine(infoLog.GetLogType());

var warningLog = new WarningLog()
{
    Message = "Warning Message",
    Date = DateTime.Now,
    Type = LogType.Warning,
    IsImportant = true
};

Console.WriteLine(warningLog.GetLogType());



var consoleLogger = new ConsoleLogger("ConsoleLogger", ConsoleColor.Red);

consoleLogger.Log("Uygulama basladi!", LogType.Info);


var fileLogger = new FileLogger("FileLogger", "C:\\Users\\alper\\Desktop\\logs.txt");

consoleLogger.Log("File Logger olusturuldu!", LogType.Info);

fileLogger.Log("File Logger olusturuldu!", LogType.Info);

consoleLogger.Log("File Logger calistirildi. logs.txt'ye yazi yazilmistir!", LogType.Info);


consoleLogger.LogToConsole("File Logger calistirildi. logs.txt'ye yazi yazilmistir!", LogType.Info);

fileLogger.LogToConsole("Bugun isler cok guzel!", LogType.Info);

var databaseLogger = new DatabaseLogger();

consoleLogger.Log("Database Logger olusturuldu!", LogType.Info);

databaseLogger.LogToConsole("DB'ye kayit acildi.", LogType.Info);

Console.ReadKey();