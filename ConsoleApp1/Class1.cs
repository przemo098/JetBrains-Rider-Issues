namespace ConsoleApp1;

public class Class1
{
    public static async Task FetchToDatabase()
    {
        await Task.Delay(800);
        var list = new List<string> { "a", "b", "c" };
        var throwError = list[^0];
    }
    
    public static async Task CallNested()
    {
        await Task.Delay(100);
        await NestedClass.NestedFunction();
    }
}