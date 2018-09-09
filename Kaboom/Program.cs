using System;
using Kaboom.Settings;
class Program
{
    static void Main(string[] args)
    {
        // Unhandled Exception
        throw new Exception("Kaboom! This exception is not handled by our application!");

        try
        {
            // Handled Exception
            throw new Exception("Kaboom! This exception is handled by our application!");

            // Demonstrate first chance exception with inner exceptions
            KaboomSettings.SetValue(null, null);

            // Demonstrate first chance exception swallowing if it occurs in particular assembly
            var value = KaboomSettings.GetValue(null);
            Console.WriteLine(value);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        Console.ReadKey();
    }





























    //static void Main(string[] args)
    //{
    //    AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
    //    throw new Exception("Kaboom");
    //}


    //private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
    //{
    //    Console.WriteLine(e.ExceptionObject.ToString());
    //    Console.WriteLine("Press Enter to continue");
    //    Console.ReadLine();
    //    Environment.Exit(1);
    //}
}