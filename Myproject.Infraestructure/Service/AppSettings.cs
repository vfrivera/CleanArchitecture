using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Infraestructure.Service
{
    public class AppSettings
    {

        #region PROPERTIES
        public ConnectionStrings ConnectionStrings { get; set; }
        public RabbitConfigurations RabbitConfigurations { get; set; }
        public ServicioEmpresasPublish ServicioEmpresasPublish { get; set; }
        public ServicioEmpresasSubscribe ServicioEmpresasSubscribe { get; set; }
        public string UserBD { get; set; }
        public string PasswordBD { get; set; }
        #endregion
    }

    public class ConnectionStrings
    {
        #region PROPERTIES
        public string SqlServerConnection { get; set; }
        #endregion
    }

    public class RabbitConfigurations
    {
        #region PROPERTIES
        public string HostName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        #endregion
    }

    public class PublishSubscribe
    {
        #region PROPERTIES
        public string Exchange { get; set; }
        public string Queue { get; set; }
        public string Routingkey { get; set; }
        public string BindingKey { get; set; }
        #endregion
    }
    public class ServicioEmpresasPublish : PublishSubscribe { };

    public class ServicioEmpresasSubscribe : PublishSubscribe { };

}