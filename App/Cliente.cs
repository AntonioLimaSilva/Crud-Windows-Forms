//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string logradouro { get; set; }
        public Nullable<int> id_grupo_economico { get; set; }
    
        public virtual GrupoEconomico GrupoEconomico { get; set; }
    }
}
