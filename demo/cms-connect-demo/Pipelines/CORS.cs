using System.Web.Http;
using Sitecore.Pipelines;
using System.Web.Http.Cors;

namespace cms_connect_demo.Pipelines
{
    public class CORS
    {
        public void Process(PipelineArgs args)
        {
            //GlobalConfiguration.Configuration.EnableCors(new EnableCorsAttribute("*", "*", "*"));

        }
    }
}