//@CodeCopy
//MdStart
namespace QTMusicStore.AspMvc
{
    /// <summary>
    /// Extension Program
    /// </summary>
    public partial class Program
    {
        /// <summary>
        /// Services can be added using this method.
        /// </summary>
        /// <param name="builder">The builder</param>
        public static void BeforeBuild(WebApplicationBuilder builder)
        {
#if ACCOUNT_ON
            builder.Services.AddTransient<AppLogic.Contracts.Account.IRolesAccess<AppLogic.Models.Account.Role>, AppLogic.Facades.Account.RolesFacade>();
            builder.Services.AddTransient<AppLogic.Contracts.Account.IUsersAccess<AppLogic.Models.Account.User>, AppLogic.Facades.Account.UsersFacade>();
            builder.Services.AddTransient<AppLogic.Contracts.Account.IIdentitiesAccess<AppLogic.Models.Account.Identity>, AppLogic.Facades.Account.IdentitiesFacade>();
#if ACCESSRULES_ON
            builder.Services.AddTransient<AppLogic.Contracts.Access.IAccessRulesAccess<AppLogic.Models.Access.AccessRule>, AppLogic.Facades.Access.AccessRulesFacade>();
#endif
#endif
            AddServices(builder);
        }
        /// <summary>
        /// Configures can be added using this method.
        /// </summary>
        /// <param name="app"></param>
        public static void AfterBuild(WebApplication app)
        {
            AddConfigures(app);
        }
        static partial void AddServices(WebApplicationBuilder builder);
        static partial void AddConfigures(WebApplication app);
    }
}
//MdEnd
