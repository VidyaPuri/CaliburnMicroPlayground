using Autofac;
using Caliburn.Micro;
using Caliburn.Micro.Autofac;
using System.Windows;

namespace CaliburnMicroTutorial
{
    public class Bootstrapper : AutofacBootstrapper<ShellViewModel>
    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override void ConfigureBootstrapper()
        {
            base.ConfigureBootstrapper();
            EnforceNamespaceConvention = false;
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<ShellViewModel>().SingleInstance();
            //builder.RegisterType<HeaderViewModel>().SingleInstance();
            //builder.RegisterType<ContentViewModel>().SingleInstance();

            builder.RegisterType<GreetingsMessageProvider>().SingleInstance();
            builder.RegisterType<Operations>().SingleInstance();
        }

        //protected override void Configure()
        //{
        //    _container.Singleton<IWindowManager, WindowManager>();
        //    _container.Singleton<ShellViewModel>();
        //    _container.Singleton<GreetingsMessageProvider>();
        //}

        //protected override object GetInstance(Type service, string key)
        //{
        //    return _container.GetInstance(service, key);
        //}

        //protected override IEnumerable<object> GetAllInstances(Type service)
        //{
        //    return _container.GetAllInstances(service);
        //}

        //protected override void BuildUp(object instance)
        //{
        //    _container.BuildUp(instance);
        //}

    }
}
