namespace WebsiteBanHang.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductDetail")]
    public partial class ProductDetail
    {
        [Key]
        [StringLength(50)]
        public string masanpham { get; set; }

        [StringLength(100)]
        public string xuatxu { get; set; }

        [StringLength(150)]
        public string tinhtrang { get; set; }

        [StringLength(50)]
        public string dongxe { get; set; }

        [StringLength(50)]
        public string sokmdadi { get; set; }

        [StringLength(50)]
        public string mau { get; set; }

        public virtual Product Product { get; set; }
    }
}
