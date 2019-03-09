using System;
using Xunit;
using src;

namespace test
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      string J = "aA";
      string S = "aAAbbbb";

      Assert.Equal(3, Program.NumJewelsInStones(J, S));

      J = "z";
      S = "ZZ";

      Assert.Equal(0, Program.NumJewelsInStones(J, S));
    }
  }
}
