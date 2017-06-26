using System;
using System.Configuration;

namespace testAutomation.Constants
{
    public static class Constants
    {      
        public static String forceRemote = ConfigurationManager.AppSettings["forceRemote"];
        public static String browserStackUser = ConfigurationManager.AppSettings["browserstack.user"];
        public static String browserStackKey = ConfigurationManager.AppSettings["browserstack.key"];
        public static String browserStackHub = ConfigurationManager.AppSettings["browserstack.hub"];
        public static String version = ConfigurationManager.AppSettings["version"];
        public static String os = ConfigurationManager.AppSettings["os"];
        public static String osVersion = ConfigurationManager.AppSettings["os_version"];
        public static String browser = ConfigurationManager.AppSettings["browser"];        
    }
}
