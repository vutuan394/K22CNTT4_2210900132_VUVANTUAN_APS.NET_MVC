﻿using System.Web;
using System.Web.Mvc;

namespace Lesson03_VVT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
