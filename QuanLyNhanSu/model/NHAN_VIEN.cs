namespace QuanLyNhanSu.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHAN_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAN_VIEN()
        {
            PHONG_BAN1 = new HashSet<PHONG_BAN>();
        }

        [Key]
        [StringLength(10)]
        public string MA_NV { get; set; }

        [StringLength(20)]
        public string TEN_NV { get; set; }

        [StringLength(30)]
        public string HO_NV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY_SINH { get; set; }

        public double? LUONG { get; set; }

        [StringLength(50)]
        public string DIA_CHI { get; set; }

        [StringLength(10)]
        public string MA_NQL { get; set; }

        [StringLength(10)]
        public string GIOI_TINH { get; set; }

        [StringLength(10)]
        public string MA_PB { get; set; }

        public virtual PHONG_BAN PHONG_BAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHONG_BAN> PHONG_BAN1 { get; set; }

        public virtual THAN_NHAN THAN_NHAN { get; set; }
    }
}
