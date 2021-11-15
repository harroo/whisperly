
using System;
using System.Net;

namespace WhisperlyServer.UserGeneration.Visual {

    public static class ImageBuilder {

        public static ImageSet BuildRandom () {

            ImageSet set = new ImageSet();

            WebClient client = new WebClient();

            Random random = new Random();
            int randomSeed = random.Next(10000, 100000);

            for (float i = 0.3f; i < 2.1f; i += 0.1f) {

                string getAddress
                    = "https://thisanimedoesnotexist.ai/results/psi-"
                    + i.ToString("0.0")
                    + "/seed"
                    + randomSeed.ToString()
                    + ".png"
                ;

                set.images.Add(new Image(
                    randomSeed.ToString() + "_" + i.ToString("0.0"),
                    client.DownloadData(getAddress)
                ));
            }

            return set;
        }
    }
}
