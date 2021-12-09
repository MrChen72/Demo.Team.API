using Demo3s.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Demo3s.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Demo3sController : AbpController
    {
        protected Demo3sController()
        {
            LocalizationResource = typeof(Demo3sResource);
        }
    }
}