
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CNPMNC.Models
{

using System;
    using System.Collections.Generic;
    
public partial class GiaoVien
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public GiaoVien()
    {

        this.Days = new HashSet<Day>();

    }


    public int MaGiaoVien { get; set; }

    public string MatKhau { get; set; }

    public string HoTen { get; set; }

    public string SoDienThoai { get; set; }

    public string Email { get; set; }

    public string DiaChi { get; set; }

    public Nullable<byte> DaXoa { get; set; }

    public Nullable<byte> LaTruongBM { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Day> Days { get; set; }

}

}
