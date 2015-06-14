using System.Web;

namespace IDeliverable.Licensing
{
    internal static class HttpRequestExtensions
    {
        public static string GetHttpHost(this HttpRequestBase request)
        {
            var host = request.ServerVariables["HTTP_HOST"];

            if (host?.Contains(":") == true)
                host = host.Substring(0, host.IndexOf(':'));

            return host;
        }
    }
}