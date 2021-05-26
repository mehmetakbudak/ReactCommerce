using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactCommerce.Models.Entities
{
    /// <summary>
    /// The territory.
    /// </summary>
    public partial class Territory: BaseEntity
    {
        /// <summary>
        /// Gets or sets the territory description.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string TerritoryDescription { get; set; }

        /// <summary>
        /// Gets or sets the region id.
        /// </summary>
        public int RegionId { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        public virtual Region Region { get; set; }

        /// <summary>
        /// Gets or sets the employee territories.
        /// </summary>
        public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
