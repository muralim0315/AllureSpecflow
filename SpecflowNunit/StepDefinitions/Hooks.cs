using Allure.Commons;
using NUnit.Framework;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;


namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        private AllureLifecycle _allureLifecycle;

        public Hooks()
        {
            _allureLifecycle = AllureLifecycle.Instance;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Environment.CurrentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        [OneTimeSetUp]
        public void SetupForAllure()
        {
            Environment.CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
        }
    }
}
