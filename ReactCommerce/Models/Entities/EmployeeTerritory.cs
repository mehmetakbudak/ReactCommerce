using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReactCommerce.Models.Entities
{
    public partial class EmployeeTerritory: BaseEntity
    {
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the territory id.
        /// </summary>
        [Required]
        [StringLength(20)]
        public string TerritoryId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Territory Territory { get; set; }
    }
}
