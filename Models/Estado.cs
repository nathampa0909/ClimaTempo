namespace ClimaTempo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estado")]
    public partial class Estado
    {
        public Estado()
        {
            Cidade = new HashSet<Cidade>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [StringLength(2)]
        public string UF { get; set; }

        public virtual ICollection<Cidade> Cidade { get; set; }
    }
}
