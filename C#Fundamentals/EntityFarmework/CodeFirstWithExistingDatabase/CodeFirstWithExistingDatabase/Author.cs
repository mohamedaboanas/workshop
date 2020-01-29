namespace CodeFirstWithExistingDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Author
    {
        public Author()
        {
            Courses = new HashSet<Cours>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Cours> Courses { get; set; }
    }
}
