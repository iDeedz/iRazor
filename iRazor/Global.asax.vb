Imports System.Web.Http
Imports System.Web.Optimization

Public Class WebApiApplication
    Inherits HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf Register)
        RegisterGlobalFilters(GlobalFilters.Filters)
        RegisterRoutes(RouteTable.Routes)
        RegisterBundles(BundleTable.Bundles)
    End Sub
End Class
