namespace QuanLyNhanSu.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DU_AN
    {
        [Key]
        [StringLength(10)]
        public string MA_DA { get; set; }

        [StringLength(50)]
        public string TEN_DA { get; set; }

        [StringLength(50)]
        public string DIA_DIEM { get; set; }

        [StringLength(10)]
        public string MA_PB { get; set; }

        public virtual PHONG_BAN PHONG_BAN { get; set; }
    }
}
