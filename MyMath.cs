using System;

namespace ISS.LIB
{
    public static class MyMath
    {
        static Random random = new Random();

        public static int RNDInt(int N)
        {
            return random.Next(N);
        }
    }
}

