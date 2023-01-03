//@CodeCopy
//MdStart
namespace TemplateCodeGenerator.AppLogic.Common
{
    [Flags]
    public enum UnitType : long
    {
        General = 1,

        AppLogic = 2 * General,
        WebApi = 2 * AppLogic,

        AspMvc = 2 * WebApi,
        Angular = 2 * AspMvc,
    }
}
//MdEnd
