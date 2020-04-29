using System;
using System.Collections.Generic;

namespace API_Example.DA
{
    public class FakeDatabase
    {
        public static List<appdata> apps = new List<appdata>()
        {
            new appdata()
            {
                appid = "a1",
                appsecret = "12345",
                scopes = "PublicAuthorize"
            },
            new appdata()
            {
                appid = "a2",
                appsecret = "12345",
                scopes = "PublicAuthorize2"
            },
            new appdata()
            {
                appid = "a3",
                appsecret = "12345",
                scopes = "PublicAuthorize, PublicAuthorize2"
            },
        };
        public class appdata
        {
            public string appid { get; set; }
            public string appsecret { get; set; }
            public string scopes { get; set; }
        }
    }
}
