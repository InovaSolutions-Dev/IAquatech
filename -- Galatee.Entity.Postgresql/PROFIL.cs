//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Galatee.Entity.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROFIL
    {
        public PROFIL()
        {
            this.CENTREDUPROFIL = new HashSet<CENTREDUPROFIL>();
            this.MENUSDUPROFIL = new HashSet<MENUSDUPROFIL>();
            this.PROFILSUTILISATEUR = new HashSet<PROFILSUTILISATEUR>();
        }
    
        public int PK_ID { get; set; }
        public int FK_IDFONCTION { get; set; }
        public string LIBELLE { get; set; }
        public string CODE { get; set; }
    
        public virtual ICollection<CENTREDUPROFIL> CENTREDUPROFIL { get; set; }
        public virtual FONCTION FONCTION { get; set; }
        public virtual ICollection<MENUSDUPROFIL> MENUSDUPROFIL { get; set; }
        public virtual ICollection<PROFILSUTILISATEUR> PROFILSUTILISATEUR { get; set; }
    }
}
