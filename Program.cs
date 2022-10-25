using System.Diagnostics;

namespace winforms_nativeaot;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        System.Runtime.InteropServices.ComWrappers.RegisterForMarshalling(WinFormsComInterop.WinFormsComWrappers.Instance);
        
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        Application.ApplicationExit += (s, e) =>
        {
            stopwatch.Stop();
            Trace.WriteLine($"winforms_nativeaot: time taken: {stopwatch.ElapsedMilliseconds}");
        };

        Application.Run(new Form1());
    }    
}
