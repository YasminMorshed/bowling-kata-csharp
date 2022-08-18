using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace BowlingLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Strike()
    {
        // Tests that we expect to return true.
        int result = BowlingLibrary.CalculateScore("X");
        Assert.IsTrue(result == 10);
    }
}
