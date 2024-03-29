﻿using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;


namespace MVCStudioBeansWebsite
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}