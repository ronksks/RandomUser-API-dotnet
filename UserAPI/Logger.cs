namespace UserAPI
    {
    public static class Logger
        {
        private static string _logFilePath;

        public static void Initialize(string logFileName)
            {
            var logDirectoryPath = Path.Combine(Directory.GetCurrentDirectory(), "logs");

            if (!Directory.Exists(logDirectoryPath))
                {
                Directory.CreateDirectory(logDirectoryPath);
                }

            _logFilePath = Path.Combine(logDirectoryPath, logFileName);

            // Clear the log file
            File.WriteAllText(_logFilePath, string.Empty);
            }

        public static void Log(string message)
            {
            var logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";

            Console.WriteLine(logMessage);

            // Write the log message to the log file
            File.AppendAllText(_logFilePath, $"{logMessage}\n");
            }
        }
    }
