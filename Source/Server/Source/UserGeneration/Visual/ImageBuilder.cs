
using System;
using System.Net;

namespace WhisperlyServer.UserGeneration.Visual {

    public static class ImageBuilder {

        public static int GetImageSeed () {

            Random random = new Random();
            return random.Next(10000, 100000);
        }

        public static ImageSet BuildRandomSET () {

            return BuildRandomSET(GetImageSeed());
        }

        public static ImageSet BuildRandomSET (int randomSeed) {

            ImageSet set = new ImageSet();

            WebClient client = new WebClient();

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

        public static Image BuildRandomPFP () {

            return BuildRandomPFP(GetImageSeed());
        }

        public static Image BuildRandomPFP (int randomSeed) {

            WebClient client = new WebClient();

            string getAddress
                = "https://www.thiswaifudoesnotexist.net/example-"
                + randomSeed.ToString()
                + ".jpg"
            ;

            return new Image(
                randomSeed.ToString(),
                client.DownloadData(getAddress)
            );
        }
    }
}
