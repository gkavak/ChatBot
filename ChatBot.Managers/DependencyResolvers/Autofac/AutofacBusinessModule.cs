using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using ChatBot.Common.Utils.Interceptors;
using ChatBot.Common.Utils.Security.JWT;
using ChatBot.DataLayer.Abstract;
using ChatBot.DataLayer.Concrete;
using ChatBot.Managers.Abstract;
using ChatBot.Managers.Concrete;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;

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
            builder.RegisterType<MsSQLDbContext>().As<MsSQLDbContext>().SingleInstance();//??
            builder.RegisterType<ChatBotQuestionDAL>().As<IChatBotQuestionDAL>().SingleInstance();

            builder.RegisterType<ChatBotEntryManager>().As<IChatBotEntryManager>().SingleInstance();

            builder.RegisterType<ChatBotEntryDAL>().As<IChatBotEntryDAL>().SingleInstance();

            builder.RegisterType<ChatBotManager>().As<IChatBotManager>().SingleInstance();

            builder.RegisterType<AuthorizationManager>().As<IAuthorizationManager>();
            builder.RegisterType<JWTHelper>().As<ITokenHelper>();

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
