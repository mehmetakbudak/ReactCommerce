using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Xml.Serialization;

namespace ReactCommerce.Models.Entities
{
    /// <summary>
    /// The category.
    /// </summary>
    public partial class Category: BaseEntity
    {

        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }
    }
}
