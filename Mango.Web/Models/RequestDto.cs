using static Mango.Web.ApiType.SD;

namespace Mango.Web.Models
{
    public class RequestDto
    {
        public ApiType.SD.ApiType ApiType { get; set; } = Web.ApiType.SD.ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
