using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // Filtro global de Authorize
            filters.Add(new AuthorizeAttribute());

            // Filtro para que a aplicação seja acessada somente por HTTPS
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
