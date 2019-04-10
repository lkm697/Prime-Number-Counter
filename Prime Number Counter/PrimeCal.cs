using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prime_Number_Counter
{
    public class PrimeCal
    {
        private static Int64 counter1 = 0;
        private static Int64 counter2 = 0;
        private static Int64 counter3 = 0;
        private static Int64 counter4 = 0;
        private static Int64 counter5 = 0;
        private static Int64 counter6 = 0;
        private static Int64 counter7 = 0;
        private static Int64 counter8 = 0;
        private static Int64 counter9 = 0;
        private static Int64 counter10 = 0;
        private static Int64[] Primes = new Int64[1000];


        private static Int64 numbers = 1000;
        private static long min = 2;
        private static long max = 1000;

        public static void  PrimeCount(long xmin, long xmax, out long xtotal, out string xouttime)
        {
            counter1 = counter2 = counter3 = counter4 = counter5 = counter6 = counter7 = counter8 = counter9 = counter10 = 0;
            min = xmin;
            max = xmax;


            Int64 total = 0;
           // PrimeList();

            
            //Console.WriteLine("\n Starting Threads: 10");
            var stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            

            Thread t1 = new Thread(FPrime);
            t1.Start();
            Thread t2 = new Thread(SPrime);
            t2.Start();

            Thread t3 = new Thread(TPrime);
            t3.Start();
            Thread t4 = new Thread(FourPrime);
            t4.Start();
            Thread t5 = new Thread(FivePrime);
            t5.Start();
            Thread t6 = new Thread(SixPrime);
            t6.Start();
            Thread t7 = new Thread(SevenPrime);
            t7.Start();
            Thread t8 = new Thread(EightPrime);
            t8.Start();
            Thread t9 = new Thread(NinePrime);
            t9.Start();
            Thread t10 = new Thread(TenPrime);
            t10.Start();
            t1.Join(); //wait here until t1 has terminated...
            t2.Join(); //wait here until t2 has terminated...
            t3.Join(); //wait here until t3 has terminated...
            t4.Join();
            t5.Join();
            t6.Join();
            t7.Join();
            t8.Join();
            t9.Join();
            t10.Join();

            //Console.WriteLine("All threads complete");





            stopwatch.Stop();


            total = counter1 + counter2 + counter3 + counter4 + counter5 + counter6 + counter7 + counter8 + counter9 + counter10;

            //Console.WriteLine("There are {0} prime numbers between 3 and {1}.", total, numbers);

            TimeSpan ts = stopwatch.Elapsed;
             string outtime = $"{ts.Minutes} minutes, {ts.Seconds} seconds, {ts.Milliseconds} milliseconds";
            //Console.ReadLine();

            //2.387
            //2.358
            //2.257

            //return total;
            xouttime = outtime;
            xtotal = total;
        }

            private static void PrimeList()
        {
            int pc = 0;
            for (int i = 2; i <= 7920; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Primes[pc] = i;
                    pc++;
                }

            }

            /*
            for (int i = 0; i < Primes.Length; i++)
            {
                Console.Write("{0} ", Primes[i].ToString());
            }
            */
        }

        private static void FPrime()
        {
            long spread = max - min;
            long localmax = min + (spread / 10); 

            
            //counter1 += 1000;
            for (long i = min; i <= localmax; i++)
            {
                bool isPrime = true;
                /*
                for (int x = 0; x <= 999; x++)
                {
                    if (i % Primes[x] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                */

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    counter1++;
                }

            }
        }

        private static void SPrime()
        {
            long localmin, localmax, spread;
            spread = max - min;
            localmin = min + (spread / 10);
            localmax = min + (spread * 2 / 10);


            //num = 1000000; num1 = 2000000;
            for (long i = localmin; i <= localmax; i++)
            {
                bool isPrime = true;
                /*
                for (int x = 0; x <= 999; x++)
                {
                    if (i % Primes[x] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                */
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    counter2++;
                }


            }
        }

        private static void TPrime()
        {
            long localmin, localmax, spread;
            spread = max - min;
            localmin = min + (spread * 2 / 10);
            localmax = min + (spread * 3 / 10);

            
            for (long i = localmin; i <= localmax; i++)
            {
                bool isPrime = true;
                /*
                for (int x = 0; x <= 999; x++)
                {
                    if (i % Primes[x] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                */

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    counter3++;
                }

            }
        }

        private static void FourPrime()
        {
            long localmin, localmax, spread;
            spread = max - min;
            localmin = min + (spread * 3 / 10);
            localmax = min + (spread * 4 / 10);
            
            for (long i = localmin; i <= localmax; i++)
            {
                bool isPrime = true;
                /*
                for (int x = 0; x <= 999; x++)
                {

                    if (i % Primes[x] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                */
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    counter4++;
                }


            }
        }

        private static void FivePrime()
        {
            long localmin, localmax, spread;
            spread = max - min;
            localmin = min + (spread * 4 / 10);
            localmax = min + (spread * 5 / 10);

            
            for (long i = localmin; i <= localmax; i++)
            {
                bool isPrime = true;
                /*
                for (int x = 0; x <= 999; x++)
                {
                    if (i % Primes[x] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                */
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    counter5++;
                }


            }
        }


        private static void SixPrime()
        {
            long localmin, localmax, spread;
            spread = max - min;
            localmin = min + (spread * 5 / 10);
            localmax = min + (spread * 6 / 10);
            
            for (long i = localmin; i <= localmax; i++)
            {
                bool isPrime = true;
                /*
                for (int x = 0; x <= 999; x++)
                {
                    if (i % Primes[x] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                */

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    counter6++;
                }


            }
        }


        private static void SevenPrime()
        {
            long localmin, localmax, spread;
            spread = max - min;
            localmin = min + (spread * 6 / 10);
            localmax = min + (spread * 7 / 10);
            
            for (long i = localmin; i <= localmax; i++)
            {
                bool isPrime = true;
                /*
                for (int x = 0; x <= 999; x++)
                {

                    if (i % Primes[x] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                */
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    counter7++;
                }


            }
        }


        private static void EightPrime()
        {
            long localmin, localmax, spread;
            spread = max - min;
            localmin = min + (spread * 7 / 10);
            localmax = min + (spread * 8 / 10);
            
            for (long i = localmin; i <= localmax; i++)
            {
                bool isPrime = true;
                /*
                for (int x = 0; x <= 999; x++)
                {
                    if (i % Primes[x] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                */
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    counter8++;
                }


            }
        }


        private static void NinePrime()
        {
            long localmin, localmax, spread;
            spread = max - min;
            localmin = min + (spread * 8 / 10);
            localmax = min + (spread * 9 / 10);
            
            for (long i = localmin; i <= localmax; i++)
            {
                bool isPrime = true;
                /*
                for (int x = 0; x <= 999; x++)
                {
                    if (i % Primes[x] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                */
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    counter9++;
                }


            }
        }

        private static void TenPrime()
        {
            long localmin, localmax, spread;
            spread = max - min;
            localmin = min + (spread * 9 / 10);
            localmax = max;
            
            for (long i = localmin; i <= localmax; i++)
            {
                bool isPrime = true;
                /*
                for (int x = 0; x <= 999; x++)
                {
                    if (i % Primes[x] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                */
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    counter10++;
                }


            }
        }


    }
    

}
