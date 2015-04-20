using System.ServiceModel;
using System.ServiceModel.Web;

namespace TestWebsiteWithWcf.Net40.WebServices
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebGet(UriTemplate = "/getdata")]
        string GetData();
    }
}