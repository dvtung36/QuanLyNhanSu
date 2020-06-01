namespace QuanLyNhanSu.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class THAN_NHAN
    {
        [Key]
        [StringLength(10)]
        public string MA_NV { get; set; }

        [StringLength(50)]
        public string TEN_TN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_SINH { get; set; }

        [StringLength(20)]
        public string QUAN_HE { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}
