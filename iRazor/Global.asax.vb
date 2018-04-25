Imports System.Web.Routing

Public Class iRazor
    Inherits HttpApplication

    Sub Application_Start()
        RouteTable.Routes.MapHubs()
    End Sub
End Class
