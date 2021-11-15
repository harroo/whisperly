
using System;
using System.IO;

namespace WhisperlyServer {

    using UserGeneration.Naming;

    public static class Program {

        public static void Main (string[] args) {

            for (int i = 0; i < 69; i++) {

                Name name = NameBuilder.BuildRandom();

                Console.WriteLine(name.nickname +": "+ name.first + " "+name.middle+" "+name.last);
            }
        }
    }
}
