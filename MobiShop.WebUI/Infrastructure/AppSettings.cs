using System;
using System.Linq;
using System.Configuration;
using System.Web.Mvc;
using MobiShop.Core.Interface.Service;

namespace MobiShop.WebUI.Infrastructure
{
    public class AppSettings
    {
        public static int ListByManufacureIdNumberPerPage
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["ListByManufacureIdNumberPerPage"]);
            }
        }

        public static int NumberProductDisplayAtHomePage
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["NumberProductDisplayAtHomePage"]);
            }
        }

        public static int MaxHeaderDescriptionLength
        {
            get
            {
                return int.Parse(ConfigurationManager.AppSettings["MaxHeaderDescriptionLength"]);
            }
        }

        public static string ThumbPrefix
        {
            get { return "thumb_"; }
        }

        public static string CompanyName
        {
            get
            {
                ICompanyService service =
                    (ICompanyService)DependencyResolver.Current.GetService(typeof(ICompanyService));
                return service.GetById(1).Name;
            }
        }
    }
}