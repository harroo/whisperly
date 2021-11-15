
using System;
using System.Collections.Generic;

namespace WhisperlyServer.UserGeneration.Visual {

    public class ImageSet {

        public List<Image> images = new List<Image>();

        public Image GetRandom () {

            Random random = new Random();

            return images[random.Next(0, images.Count - 1)];
        }
    }

    public class Image {

        public string name;
        public byte[] data;

        public Image (byte[] data) {

            this.data = data;
        }

        public Image (string name, byte[] data) {

            this.name = name;
            this.data = data;
        }
    }
}
