using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using ChatBot.Common.Utils.Interceptors;
using ChatBot.DataLayer.Abstract;
using ChatBot.DataLayer.Concrete;
using ChatBot.Managers.Abstract;
using ChatBot.Managers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Managers.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //register dependencies
            builder.RegisterType<UserManager>().As<IUserManager>().SingleInstance();
            builder.RegisterType<UserDAL>().As<IUserDAL>().SingleInstance();
            builder.RegisterType<ChatBotQuestionManager>().As<IChatBotQuestionManager>().SingleInstance();

            builder.RegisterType<ChatBotQuestionDAL>().As<IChatBotQuestionDAL>().SingleInstance();

            builder.RegisterType<ChatBotEntryManager>().As<IChatBotEntryManager>().SingleInstance();

            builder.RegisterType<ChatBotEntryDAL>().As<IChatBotEntryDAL>().SingleInstance();

            builder.RegisterType<ChatBotManager>().As<IChatBotManager>().SingleInstance();

            // register interceptor
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
