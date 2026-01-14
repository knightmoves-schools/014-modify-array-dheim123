namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Return_The_Second_Element_In_The_Seasons_Array_From_The_Method_FindCurrentSeason(){
        var calendar = new Calendar();
        Assert.Equal("Fall", calendar.Seasons[1]);
        calendar.FindCurrentSeason();
        Assert.Equal("Autumn", calendar.Seasons[1]);
    }
}