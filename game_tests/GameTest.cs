using Xunit;
using SpaceGame;

public class SpaceTest 
{
    [Fact]
    public void Test() 
    {   
        Ship player = new Ship();
        Assert.Equal(player.testFunction(), "This works");
    }
}