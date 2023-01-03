//@CodeCopy
//MdStart
#if ACCOUNT_ON && ACCESSRULES_ON
namespace QTMusicStore.WebApi.Controllers.Access
{
    ///
    /// Implemented from template developer
    ///
    public sealed partial class AccessRulesController : GenericController<AppLogic.Models.Access.AccessRule, WebApi.Models.Access.AccessRuleEdit, WebApi.Models.Access.AccessRule>
    {
        static AccessRulesController()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        ///
        /// Implemented from template developer
        ///
        public AccessRulesController(AppLogic.Contracts.Access.IAccessRulesAccess<AppLogic.Models.Access.AccessRule> other)
        : base(other)
        {
            Constructing();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Implemented from template developer
        ///
        protected override WebApi.Models.Access.AccessRule ToOutModel(AppLogic.Models.Access.AccessRule accessModel)
        {
            var handled = false;
            var result = default(QTMusicStore.WebApi.Models.Access.AccessRule);
            BeforeToOutModel(accessModel, ref result, ref handled);
            if (handled == false || result == null)
            {
                result = WebApi.Models.Access.AccessRule.Create(accessModel);
            }
            AfterToOutModel(result);
            return result;
        }
        partial void BeforeToOutModel(AppLogic.Models.Access.AccessRule accessModel, ref WebApi.Models.Access.AccessRule? outModel, ref bool handled);
        partial void AfterToOutModel(WebApi.Models.Access.AccessRule outModel);
    }
}
#endif
//MdEnd
