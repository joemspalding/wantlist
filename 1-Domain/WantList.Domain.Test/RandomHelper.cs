using System;
using System.Linq;

namespace WantList.Domain.Test {
    public class RandomHelper {
        private static Random rand = new Random();
        public static string GetRandomString(int length){
            const string chars = @"aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789!@#$%^&*()-_=+";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rand.Next(s.Length)]).ToArray());
        }

        public static double GetRandomDouble(){
            return rand.NextDouble();
        }

        public static int GetRandomInt(){
            return rand.Next();
        }

        public static bool GetRandomBool(){
            int rando = rand.Next(0,1);
            return rando == 1;
        }
    }
}
