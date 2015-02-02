namespace PaperseedPortal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("papersee_masterdb.tbltest")]
    public partial class tbltest
    {
        public int id { get; set; }

        [StringLength(20)]
        public string userid { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime doj { get; set; }
    }
}
