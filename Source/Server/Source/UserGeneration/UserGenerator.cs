
using System;
using System.Net;

namespace WhisperlyServer.UserGeneration {

    using Visual;
    using Naming;

    public static class UserGenerator {

        public static Identity Generate () {

            Random random = new Random();

            Identity identity = new Identity();

            identity.imageSet = ImageBuilder.BuildRandom();
            identity.name = NameBuilder.BuildRandom();
            identity.age = random.Next(14, 26);
            identity.profilePicture = identity.imageSet.GetRandom();

            return identity;
        }
    }
}
