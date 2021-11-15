
using System;
using System.Net;

namespace WhisperlyServer.UserGeneration.Naming {

    public static class NameBuilder {

        private static Random random = new Random();

        public static Name BuildRandom () {

            Name name = new Name();

            name.first = GenerateFirstName();
            name.middle = GenerateFirstName();
            name.last = GenerateFirstName();
            name.nickname = GenerateUsername();

            return name;
        }

        public static string GenerateFirstName () {

            string name = RandomConsonant().ToString();
            name += RandomVowel();

            for (int i = 0; i < random.Next(1, 4); ++i) {

                name += RandomConsonant();
                name += RandomVowel();
            }

            return name[0] + name.Substring(1, name.Length - 1).ToLower();
        }

        public static string GenerateUsername () {

            string name = GenerateFirstName();

            if (random.Next(0, 2) == 0)
                return RandomNumber() + RandomNumber() + name;
            else
                return name + RandomNumber() + RandomNumber();
        }

        private static string consonants = "BCDFGHJKLMNPRSTVWYZ";
        private static char RandomConsonant () {

            return consonants[random.Next(0, consonants.Length - 1)];
        }
        private static string vowels = "AEIOU";
        private static char RandomVowel () {

            return vowels[random.Next(0, vowels.Length - 1)];
        }
        private static string numbers = "0123456789";
        private static char RandomNumber () {

            return numbers[random.Next(0, numbers.Length - 1)];
        }
    }
}
