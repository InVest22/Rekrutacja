//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rekrutacja
{
    using System;
    using System.Collections.Generic;
    
    public partial class email
    {
        public int id { get; set; }
        public string email1 { get; set; }
        public int klient_id { get; set; }
    
        public virtual klient klient { get; set; }
    }
}
