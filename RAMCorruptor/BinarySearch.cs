using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMCorruptor
{
    static class BinarySearch
    {
        private class InvertedFuncGen
        {
            private Func<long, bool> func;
            private InvertedFuncGen(Func<long, bool> func)
            {
                this.func = func;
            }
            public bool GetInvertedValue(long arg)
            {
                return !func(arg);
            }

            public static Func<long, bool> GetInverted(Func<long, bool> func)
            {
                return new Func<long, bool>(new InvertedFuncGen(func).GetInvertedValue);
            }
        }

        private static long FindSeedValue(Func<long, bool> test, long min, long max, int testCount)
        {
            float step = (float)(max - min) / (long)(testCount + 1);
            for (int i = 0; i < testCount; i++) {
                long testVal = min + (long)(i * step);
                if (test(testVal)) return testVal;
            }
            throw new ArgumentException("Starting value for binary search not found in a reasonable number of guesses");
        }

        public static long FindFirstTrue(Func<long, bool> test, long min, long max, bool invert = false)
        {
            Func<long, bool> testFunc;
            if (invert) {
                testFunc = InvertedFuncGen.GetInverted(test);
            } else {
                testFunc = test;
            }

            if (min >= max) {
                throw new ArgumentOutOfRangeException("max", max, "Max must be greater than min.");
            }

            max = FindSeedValue(testFunc, min, max, 512);

            while (max - min > 1) {
                long testVal = (min + max) / 2;
                if (testFunc(testVal)) {
                    max = testVal;
                } else {
                    min = testVal;
                }
            }

            return testFunc(min) ? min : max;
        }

        public static Func<long, bool> TestingFunction
        {
            get { return new Func<long, bool>(_TestingFunction); }
        }

        private static bool _TestingFunction(long value)
        {
            return (value <= 10);
        }
    }
}
