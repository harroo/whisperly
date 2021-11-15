
using System;

namespace WhisperlyServer.UserGeneration {

    using Visual;
    using Naming;

    public class Identity {

        public ImageSet imageSet;

        public Name name;

        public int age;

        public Image profilePicture;

        public string GetSummary ()
            => "Name: " + name.first + " " + name.middle + " " + name.last + " (" + name.nickname + ")"
            + "\n" + "Age: " + age.ToString()
            + "\n" + "PFP: " + profilePicture.name
        ;
    }
}
