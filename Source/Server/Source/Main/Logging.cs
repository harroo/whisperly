
using System;

namespace WhisperlyServer {

    public static class Logging {

        public static void Log (string message) {

            Console.WriteLine("[" + DateTime.Now + "] [LOG]: " + message);
        }

        public static void LogWarning (string message) {

            Console.WriteLine("[" + DateTime.Now + "] [WARNING]: " + message);
        }

        public static void LogError (string message) {

            Console.WriteLine("[" + DateTime.Now + "] [ERROR]: " + message);
        }
    }
}
