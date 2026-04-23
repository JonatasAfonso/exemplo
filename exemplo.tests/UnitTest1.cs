namespace exemplo.tests;


public class UnitTest1
{
    [Fact] 
    public void TestSucesso()
    {
        Assert.True(true, "teste ok");
    }

    [Fact]
    public void TestSucesso2()
    {
        Assert.True(true, "teste ok");  
        Assert.True(true, "teste ok");  
    }

        [Fact]
    public void TestSucesso3()
    {
        Assert.True(true, "teste ok");
    }

        [Fact]
    public void TestFalha()
    {
        Assert.True(false, "teste com problemas");
    }
}
