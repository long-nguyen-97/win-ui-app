using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace win_ui_app.UITests
{
    [TestClass]
    public class ControllerConfigurationPageTests : TestBase
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
            // Go to Controller Configuration page
            var tab = session.FindElementByAccessibilityId("controllerConfigurationTab");
            tab.Click();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            TearDown();
        }

        [TestMethod]
        public void WhenClickInputMappingCard_ShouldGoToInputMappingPage()
        {
            var inputMappingCard = session.FindElementByAccessibilityId("inputMappingCard");
            Assert.IsNotNull(inputMappingCard);
            inputMappingCard.Click();

            var inputMappingPageText = session.FindElementByAccessibilityId("inputMappingPageText");
            Assert.IsNotNull(inputMappingPageText);
            Assert.AreEqual("This is Input Mapping page", inputMappingPageText.Text);
        }
    }
}
