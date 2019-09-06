using System;
using Kaboom.Settings;
class Program
{
    static void Main(string[] args)
    {
        // DEMO: Attach to UnhandledException event and see what happens
        // in case an exception is thrown and noone cares about it...
        //AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;

        // DEMO: Throw an unhandled exception
        //throw new Exception("Kaboom! This exception is not handled by our application!");

        try
        {
            // Handled Exception
            //throw new Exception("Kaboom! This exception is handled by our application!");

            // Demonstrate first chance exception with inner exceptions
            KaboomSettings.SetValue(null, null);

            // Demonstrate first chance exception swallowing if it occurs in particular assembly
            var value = KaboomSettings.GetValue(null);
            Console.WriteLine(value);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);

            // DEMO: Rethrow a handled exception to become unhandled
            // Rethrow the catched exception makes it become 'unhandled'
            // because noone else outside this try-catch is caring about it
            //throw;
        }

        Console.WriteLine();
        Console.WriteLine($"The program finished successfully");
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();
    }

    private static void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        Console.WriteLine();
        Console.WriteLine($"The program crashed with following exception: {e.ExceptionObject.ToString()}");
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        Environment.Exit(1);
    }
}