﻿using System.Web;
using System.Web.Mvc;

namespace Online_Shop_Babelfish
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}