using Academia.UI.Services;
using System.Web.Http;
using System.Web.Mvc;

namespace Academia.UI.WebApi.Controllers
{
    public abstract class ApiControllerBase<TUIService> : ApiController
        where TUIService : IUIService
    {
        protected TUIService UIService { get; private set; }

        public ApiControllerBase(TUIService uiService)
        {
            this.UIService = uiService;
        }
    }
}