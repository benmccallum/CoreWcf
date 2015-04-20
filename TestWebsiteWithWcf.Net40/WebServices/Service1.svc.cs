using System.ServiceModel.Activation;

namespace TestWebsiteWithWcf.Net40.WebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DirectoryService" in code, svc and config file together.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        public string GetData()
        {
            return "Hello world";
        }
    }
}
