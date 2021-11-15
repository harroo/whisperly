
using System;
using System.Net;

namespace WhisperlyServer.UserGeneration {

    using Visual;
    using Naming;

    public static class UserGenerator {

        public static Identity Generate () {

            Random random = new Random();

            Identity identity = new Identity();

            int picSeed = ImageBuilder.GetImageSeed();

            identity.imageSet = ImageBuilder.BuildRandomSET(picSeed);
            identity.name = NameBuilder.BuildRandom();
            identity.age = random.Next(14, 26);
            identity.profilePicture = ImageBuilder.BuildRandomPFP(picSeed);

            return identity;
        }
    }
}
