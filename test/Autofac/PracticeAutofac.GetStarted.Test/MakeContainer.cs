using Autofac;
using Xunit;

namespace PracticeAutofac.GetStarted.Test
{
    public class MakeContainer
    {
        private IContainer _container;

        [Fact]
        public void MakeContainerTest()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWriter>();

            _container = builder.Build();

            using (var scope = _container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWriter>();
                writer.WriteDate();
            }
        }
    }
}
