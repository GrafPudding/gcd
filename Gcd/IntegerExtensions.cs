using System;
using System.Diagnostics;
using System.Threading;

namespace Gcd
{
    /// <summary>
    /// Provide methods with integers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            int temporaryValue;
            int result;

            while (b > 0 || b < 0)
            {
                temporaryValue = a % b;
                a = b;
                b = temporaryValue;
            }

            result = Math.Abs(a);
            return result;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }

            int temporaryValue;
            int gcd;
            int result;

            while (b > 0 || b < 0)
            {
                temporaryValue = a % b;
                a = b;
                b = temporaryValue;
            }

            result = Math.Abs(a);

            while (c > 0 || c < 0)
            {
                gcd = result % c;
                result = c;
                c = gcd;
            }

            result = Math.Abs(result);
            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            int temporaryValue;
            int gcd1;
            int gcd2;
            int result;
            int i = 0;

            if (a == 0 && b == 0 && other[i] == 0 && other[1] == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (other.Length == 2 && other[1] == 1)
            {
                return 1;
            }

            if (b == 0 && other.Length == 0)
            {
                return a;
            }
            else if (a == b && other.Length == 0)
            {
                return Math.Abs(a);
            }
            else
            {
                while (b != 0)
                {
                    temporaryValue = a % b;
                    a = b;
                    b = temporaryValue;
                }

                gcd1 = Math.Abs(a);

                while (other[i] != 0 && i < other.Length)
                {
                    gcd2 = gcd1 % other[i];
                    gcd1 = other[i];
                    other[i] = gcd2;
                }

                result = Math.Abs(gcd1);
                return result;
            }
        }

        /// <summary>
        /// Calculates GCD of two integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            int temporaryValue;
            int result;

            while (b != 0)
            {
                temporaryValue = a % b;
                a = b;
                b = temporaryValue;
            }

            result = Math.Abs(a);
            return result;
        }

        /// <summary>
        /// Calculates GCD of three integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }

            int temporaryValue;
            int gcd;
            int result;

            while (b != 0)
            {
                temporaryValue = a % b;
                a = b;
                b = temporaryValue;
            }

            result = Math.Abs(a);

            while (c != 0)
            {
                gcd = result % c;
                result = c;
                c = gcd;
            }

            result = Math.Abs(result);
            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            int temporaryValue;
            int gcd1;
            int gcd2;
            int result;
            int i = 0;

            if (a == 0 && b == 0 && other[0] == 0 && other[1] == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (b == 0 && other.Length == 0)
            {
                return a;
            }
            else if (a == b && other.Length == 0)
            {
                return Math.Abs(a);
            }
            else if (other[1] == 1)
            {
                return 1;
            }
            else
            {
                while (b > 0 || b < 0)
                {
                    temporaryValue = a % b;
                    a = b;
                    b = temporaryValue;
                }

                gcd1 = Math.Abs(a);

                while (other[i] != 0 && i < other.Length)
                {
                    gcd2 = gcd1 % other[i];
                    gcd1 = other[i];
                    other[i] = gcd2;
                }

                result = Math.Abs(gcd1);
                return result;
            }
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            int temporaryValue;
            int result;

            while (b != 0)
            {
                temporaryValue = a % b;
                a = b;
                b = temporaryValue;
            }

            stopwatch.Stop();

            elapsedTicks = stopwatch.ElapsedTicks;
            result = Math.Abs(a);
            return result;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }

            int temporaryValue;
            int gcd;
            int result;

            while (b != 0)
            {
                temporaryValue = a % b;
                a = b;
                b = temporaryValue;
            }

            result = Math.Abs(a);

            while (c != 0)
            {
                gcd = result % c;
                result = c;
                c = gcd;
            }

            stopwatch.Stop();
            result = Math.Abs(result);
            elapsedTicks = stopwatch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int temporaryValue;
            int gcd1;
            int gcd2;
            int result;
            int i = 0;

            if (a == 0 && b == 0 && other[0] == 0 && other[1] == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (b == 0 && other.Length == 0)
            {
                elapsedTicks = stopwatch.ElapsedTicks;
                return a;
            }
            else if (a == b && other.Length == 0)
            {
                elapsedTicks = stopwatch.ElapsedTicks;
                return Math.Abs(a);
            }
            else if (other.Length == 2 && other[1] == 1)
            {
                elapsedTicks = stopwatch.ElapsedTicks;
                return 1;
            }
            else
            {
                while (b > 0 || b < 0)
                {
                    temporaryValue = a % b;
                    a = b;
                    b = temporaryValue;
                }

                gcd1 = Math.Abs(a);

                while (other[i] != 0 && i < other.Length)
                {
                    gcd2 = gcd1 % other[i];
                    gcd1 = other[i];
                    other[i] = gcd2;
                }

                stopwatch.Stop();
                elapsedTicks = stopwatch.ElapsedTicks;
                result = Math.Abs(gcd1);
                return result;
            }
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            int temporaryValue;
            int result;

            while (b > 0 || b < 0)
            {
                temporaryValue = a % b;
                a = b;
                b = temporaryValue;
            }

            stopwatch.Stop();

            elapsedTicks = stopwatch.ElapsedTicks;
            result = Math.Abs(a);
            return result;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }

            int temporaryValue;
            int gcd;
            int result;

            while (b > 0 || b < 0)
            {
                temporaryValue = a % b;
                a = b;
                b = temporaryValue;
            }

            result = Math.Abs(a);

            while (c != 0)
            {
                gcd = result % c;
                result = c;
                c = gcd;
            }

            stopwatch.Stop();
            result = Math.Abs(result);
            elapsedTicks = stopwatch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int temporaryValue;
            int gcd1;
            int gcd2;
            int result;
            int i = 0;

            if (a == 0 && b == 0 && other[0] == 0 && other[1] == 0)
            {
                throw new ArgumentException("exception");
            }

            if (a == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a));
            }

            if (b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b));
            }

            if (b == 0 && other.Length == 0)
            {
                elapsedTicks = stopwatch.ElapsedTicks;
                return a;
            }
            else if (a == b && other.Length == 0)
            {
                elapsedTicks = stopwatch.ElapsedTicks;
                return Math.Abs(a);
            }
            else if (other.Length == 2 && other[1] == 1)
            {
                elapsedTicks = stopwatch.ElapsedTicks;
                return 1;
            }
            else
            {
                while (b != 0)
                {
                    temporaryValue = a % b;
                    a = b;
                    b = temporaryValue;
                }

                gcd1 = Math.Abs(a);

                while (other[i] != 0 && i < other.Length)
                {
                    gcd2 = gcd1 % other[i];
                    gcd1 = other[i];
                    other[i] = gcd2;
                }

                stopwatch.Stop();
                elapsedTicks = stopwatch.ElapsedTicks;
                result = Math.Abs(gcd1);
                return result;
            }
        }
    }
}
