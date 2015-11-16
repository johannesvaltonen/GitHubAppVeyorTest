using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GitHubAppVeyorTest.Tests
{
    [TestClass]
    public class TextTests
    {
        [TestMethod]
        public void ToUpper()
        {
            const string text = "SomeThing";
            string result = Text.ToUpper(text);

            Assert.AreEqual(text.ToUpper(), result);
        }

        [TestMethod]
        public void ToLower()
        {
            const string text = "SomeThing";
            string result = Text.ToLower(text);

            Assert.AreEqual(text.ToLower(), result);
        }
    }
}