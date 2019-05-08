using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfServicetobeusedindotnetclient
{
    [DataContract]
    public class Resp
    {
        public int ok { get; set; }
    }
}