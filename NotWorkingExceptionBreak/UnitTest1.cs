using ConsoleApp1;

namespace NotWorkingExceptionBreak;

public class UnitTest1
{
    [Fact]
    public async Task NotWorking()
    {
        await Class1.FetchToDatabase();
    }    
    
    [Fact]
    public async Task AlsoNotWorking()
    {
        var list = new List<string> { "a", "b", "c" };
        var throwError = list[^0];
    }
    
    [Fact]
    public void Working()
    {
        var list = new List<string> { "a", "b", "c" };
        var throwError = list[^0];
    }
    
    [Fact]
    public async Task CallStack()
    {
        await Class1.CallNested();
    }
}