using System;
using System.Diagnostics;
using System.Threading;


namespace SGCBenchmark_Gen0Heavy
{
    class Program
    {
        
    const int NUM_ITERS_CONCAT = 10;
    const int NUM_ITERS = 5000;

    public static String s1 = "11234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s2 = "21234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s3 = "31234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s4 = "41234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s5 = "51234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s6 = "61234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s7 = "71234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s8 = "81234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s9 = "91234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static String s10 = "01234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    static void A()
    {
        string str1 = null;
		
		int counter = 0;
		
		while(counter!=200){
			
				for (long i = 0; i < NUM_ITERS; i++)
			{
				for (int j = 0; j < NUM_ITERS_CONCAT; j++)
				{
					str1 += s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10                    
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
				}

				str1 = "";
				
			}

			counter++;
		}	
			Console.WriteLine("A");            
    }
	
	static void B()
    {
        string str1 = null;
		
		int counter = 0;
		
		while(counter!=200){
			
				for (long i = 0; i < NUM_ITERS; i++)
			{
				for (int j = 0; j < NUM_ITERS_CONCAT; j++)
				{
					str1 += s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10                    
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
				}

				str1 = "";
				
			}

			counter++;
		}	
			Console.WriteLine("B");            
    }
	
	static void C()
    {
        string str1 = null;
		
		int counter = 0;
		
		while(counter!=200){
			
				for (long i = 0; i < NUM_ITERS; i++)
			{
				for (int j = 0; j < NUM_ITERS_CONCAT; j++)
				{
					str1 += s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10                    
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
				}

				str1 = "";
				
			}

			counter++;
		}	
			Console.WriteLine("C");            
    }
	
	static void D()
    {
        string str1 = null;
		
		int counter = 0;
		
		while(counter!=200){
			
				for (long i = 0; i < NUM_ITERS; i++)
			{
				for (int j = 0; j < NUM_ITERS_CONCAT; j++)
				{
					str1 += s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10                    
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
				}

				str1 = "";
				
			}

			counter++;
		}	
			Console.WriteLine("D");            
    }
	
	static void E()
    {
        string str1 = null;
		
		int counter = 0;
		
		while(counter!=200){
			
				for (long i = 0; i < NUM_ITERS; i++)
			{
				for (int j = 0; j < NUM_ITERS_CONCAT; j++)
				{
					str1 += s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10                    
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10
						+ s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8 + s9 + s10;
				}

				str1 = "";
				
			}

			counter++;
		}	
			Console.WriteLine("E");            
    }
	
	

	
	public static void Main(string[] p_args)
    {
		
    	Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

		Thread thread1 = new Thread(new ThreadStart(A));
        Thread thread2 = new Thread(new ThreadStart(B));
		Thread thread3 = new Thread(new ThreadStart(C));
        Thread thread4 = new Thread(new ThreadStart(D));
		Thread thread5 = new Thread(new ThreadStart(E));        
        thread1.Start();
        thread2.Start();
		thread3.Start();
        thread4.Start();
		thread5.Start();        
        thread1.Join();
        thread2.Join();
		thread3.Join();
        thread4.Join();
		thread5.Join();

		stopwatch.Stop();
        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed.TotalMilliseconds);
        
	}
    }
}
