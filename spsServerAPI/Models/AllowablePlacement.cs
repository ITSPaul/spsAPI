namespace spsServerAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AllowablePlacement")]
    public partial class AllowablePlacement
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlacementID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProgrammeStageID { get; set; }

        public string Comment { get; set; }

        public virtual Placement Placement { get; set; }

        public virtual ProgrammeStage ProgrammeStage { get; set; }
    }
}