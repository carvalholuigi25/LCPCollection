using System.Runtime.CompilerServices;

namespace LCPCollection.Server.Context
{
    public static class MyModuleInitializer
    {
        [ModuleInitializer]
        public static void Initialize()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
    }
}
