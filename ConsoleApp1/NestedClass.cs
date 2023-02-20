using System.Diagnostics;

namespace ConsoleApp1;

public class NestedClass
{
    public static async Task NestedFunction()
    {
        await Task.Delay(100);
        Debugger.Break();
    }
}