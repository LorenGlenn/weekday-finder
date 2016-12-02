using Xunit;
using Finder.Object;

namespace DayFinderTests
{
  public class myTests
  {
    [Fact]
    public void Test1_CheckLeapYear_True()
    {
      DayFinder test = new DayFinder("12/14/2004");
      Assert.Equal(true, test.IsLeapYear(2004));
    }

    [Fact]
    public void Test2_Counter_ReturnInt()
    {
      DayFinder test = new DayFinder("1/1/2000");
      test.Counter();
      Assert.Equal(36524, test.GetDaysSinceEpoch());
    }

    [Theory]
    [InlineData("1/2/2000")]
    [InlineData("1/9/2000")]
    [InlineData("1/16/2000")]
    [InlineData("1/23/2000")]
    [InlineData("1/30/2000")]
    public void Test3_TestSundaysInOneMonth_String(string InlineData)
    {
      DayFinder test = new DayFinder(InlineData);
      test.Counter();
      Assert.Equal("Sunday", test.GetDayOfWeek());
    }

    [Theory]
    [InlineData("4/13/2000", "Thursday")]
    [InlineData("2/7/2000", "Monday")]
    [InlineData("7/16/2000", "Sunday")]
    [InlineData("1/1/2000", "Saturday")]
    [InlineData("12/31/2000", "Sunday")]
    public void Test3_TestDaysAcrossMonth_String(string InlineData, string expectedResult)
    {
      DayFinder test = new DayFinder(InlineData);
      test.Counter();
      Assert.Equal(expectedResult, test.GetDayOfWeek());
    }

    [Theory]
    [InlineData("12/31/2000", "Sunday")]
    [InlineData("1/1/2001", "Monday")]
    [InlineData("1/1/2003", "Wednesday")]
    [InlineData("1/1/2004", "Thursday")]
    [InlineData("3/1/2002", "Friday")]
    [InlineData("9/5/2005", "Monday")]
    [InlineData("10/3/2007", "Wednesday")]
    [InlineData("12/1/2016", "Thursday")]
    [InlineData("12/2/2016", "Friday")]
    [InlineData("12/31/2016", "Saturday")]
    [InlineData("1/1/2017", "Sunday")]
    [InlineData("1/1/2018", "Monday")]
    public void Test3_TestDaysAcrossYear_String(string InlineData, string expectedResult)
    {
      DayFinder test = new DayFinder(InlineData);
      test.Counter();
      System.Console.WriteLine("Days since epoch: " + test.GetDaysSinceEpoch());
      Assert.Equal(expectedResult, test.GetDayOfWeek());
    }
  }
}
