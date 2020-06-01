namespace QuanLyNhanSu.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHONG_BAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG_BAN()
        {
            DU_AN = new HashSet<DU_AN>();
            NHAN_VIEN = new HashSet<NHAN_VIEN>();
        }

        [Key]
        [StringLength(10)]
        public string MA_PB { get; set; }

        [StringLength(50)]
        public string TEN_PB { get; set; }

        [StringLength(10)]
        public string MA_TP { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_THANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DU_AN> DU_AN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHAN_VIEN> NHAN_VIEN { get; set; }

        public virtual NHAN_VIEN NHAN_VIEN1 { get; set; }
    }
}
