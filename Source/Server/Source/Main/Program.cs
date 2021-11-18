
using System;
using System.IO;

namespace WhisperlyServer {

    public static class Program {

        public static void Main (string[] args) {

            Messages.Manager.Init();
            Messages.Manager.InitPackets();

            Network.Server.Start();

            Console.ReadKey();

            // Network.Server.Stop();
        }
    }
}
