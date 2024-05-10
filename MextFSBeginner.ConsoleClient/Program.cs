// Create FilePath Variable

string filePath = "C:\\Users\\alper\\Desktop\\AccessControlLogs.txt";

// Read the file from the path (as text)

string logFileText = File.ReadAllText(filePath);

// Split the text into an array of strings by the new line character \n

string[] logLines = logFileText.Split("\n",StringSplitOptions.RemoveEmptyEntries);

// Create a loop on the logLines array

foreach (string logLine in logLines)
{
    string[] logValues = logLine.Split("---", StringSplitOptions.RemoveEmptyEntries);
}