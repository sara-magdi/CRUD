namespace templateForm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class movies
    {
        public int id { get; set; }

        public string name { get; set; }

        public int year { get; set; }

        public int rate { get; set; }
    }
}
