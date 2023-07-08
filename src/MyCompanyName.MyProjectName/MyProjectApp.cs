using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace MyCompanyName.MyProjectName
{
    public static class MyProjectApp
    {
        internal static IAbpApplicationWithInternalServiceProvider AbpApplication { get; set; }

        public static T CreateForm<T>() where T : Form
        {
            if (AbpApplication == null) return null;
            else
            {
                var form = AbpApplication.ServiceProvider.GetService<T>();
                return form;
            }
        }

        public static T GetService<T>() where T : class
        {
            if (AbpApplication == null) return null;
            else
            {
                var service = AbpApplication.ServiceProvider.GetService<T>();
                return service;
            }
        }
    }
}
