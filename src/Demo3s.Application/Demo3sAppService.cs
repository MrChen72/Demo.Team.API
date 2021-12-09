using System;
using System.Collections.Generic;
using System.Text;
using Demo3s.Localization;
using Volo.Abp.Application.Services;

namespace Demo3s
{
    /* Inherit your application services from this class.
     */
    public abstract class Demo3sAppService : ApplicationService
    {
        protected Demo3sAppService()
        {
            LocalizationResource = typeof(Demo3sResource);
        }
    }
}
