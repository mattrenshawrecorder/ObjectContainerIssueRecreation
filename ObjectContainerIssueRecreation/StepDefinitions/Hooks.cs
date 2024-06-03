using ObjectContainerIssueRecreation.Drivers;
using Reqnroll.BoDi;

namespace ObjectContainerIssueRecreation.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun(ObjectContainer objectContainer)
        {
            // Exception thrown on this line
            objectContainer.BaseContainer.RegisterInstanceAs(new Driver());
        }
    }
}
