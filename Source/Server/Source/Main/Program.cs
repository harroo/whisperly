
using System;
using System.IO;

namespace WhisperlyServer {

    using UserGeneration;

    public static class Program {

        public static void Main (string[] args) {

            Identity id = UserGenerator.Generate();

            foreach (var image in id.imageSet.images) {

                File.WriteAllBytes(image.name+".png", image.data);
            }

            File.WriteAllBytes(id.profilePicture.name+".jpg", id.profilePicture.data);

            File.WriteAllText("INFO", id.GetSummary());
        }
    }
}
