using MextFSBeginner.Domain.Services;

string filePath = "C:\\Users\\alper\\Desktop\\BlazorArticle\\AccessControlLogs.txt";

var accessControlLogManager = new AccessControlLogManager();

var accessControlLogs = accessControlLogManager.LoadFromFile(filePath);

string writeFilePath = "C:\\Users\\alper\\Desktop\\BlazorArticle\\AccessControlLogs2.txt";

accessControlLogManager.WriteToFile(writeFilePath, accessControlLogs,"%%%");