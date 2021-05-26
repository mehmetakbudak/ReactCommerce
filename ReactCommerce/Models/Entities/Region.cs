using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactCommerce.Models.Entities
{
    /// <summary>
    /// The region.
    /// </summary>
    public partial class Region: BaseEntity
    {       
        /// <summary>
        /// Gets or sets the region description.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string RegionDescription { get; set; }

        /// <summary>
        /// Gets or sets the territories.
        /// </summary>
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
