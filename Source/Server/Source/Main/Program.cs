
using System;
using System.IO;

namespace WhisperlyServer {

    using UserGeneration.Visual;

    public static class Program {

        public static void Main (string[] args) {

            ImageSet set = ImageBuilder.BuildRandom();

            foreach (var image in set.images) {

                File.WriteAllBytes(image.name, image.data);
            }
        }
    }
}
