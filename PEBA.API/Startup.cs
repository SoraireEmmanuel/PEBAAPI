using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using PEBA.bl.Data;

namespace PEBA.API
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            //Configure the DB context to use a sigle instance per request
            app.CreatePerOwinContext(PEBAContext.Create);            
        }
    }
}
