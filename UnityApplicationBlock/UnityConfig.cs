﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnityApplicationBlock
{
    public class UnityConfig
    {
        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
     {
         var container = new UnityContainer();
         RegisterTypes(container);
         return container;

     });

        public static IUnityContainer GetUnityContainer()
        {
            return Container.Value;
        }
        public static void RegisterTypes(IUnityContainer container)
        {
            var registrationModuleAssemblyName = ConfigurationManager.AppSettings["UnityRegistrationModule"];
            var type = Type.GetType(registrationModuleAssemblyName);
            if (type == null) return;
            var module = (IContainerRegistrationModule<IUnityContainer>)Activator.CreateInstance(type);
            module.Register(container);
        }
    }

    public interface IContainerRegistrationModule<T>
    {
        void Register(IUnityContainer container);
    }
}
