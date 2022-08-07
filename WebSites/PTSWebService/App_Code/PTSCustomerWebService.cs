﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using PTSLibrary;

/// <summary>
/// Summary description for PTSCustomerWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class PTSCustomerWebService : System.Web.Services.WebService
{
    private PTSCustomerFacade facade;

    public PTSCustomerWebService()
    {
        facade = new PTSCustomerFacade();

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    [WebMethod]
    public int Authenticate(String username, String password)
    {
        return facade.Authenticate(username, password);
    }
    [WebMethod]
    public Project[] GetListOfProjects(int customerId)
    {
        return facade.GetListOfProjects(customerId);
    }

    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

}
