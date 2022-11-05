//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PerfumeShop.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.OrderElements = new HashSet<OrderElements>();
        }
    
        public int ProductId { get; set; }
        public string Articul { get; set; }
        public string Name { get; set; }
        public int MeasurementId { get; set; }
        public decimal Cost { get; set; }
        public int DiscountMaxSize { get; set; }
        public string Manufacturer { get; set; }
        public string Provider { get; set; }
        public int ProductTypeId { get; set; }
        public int Discount { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Measurements Measurements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderElements> OrderElements { get; set; }
        public virtual ProductTypes ProductTypes { get; set; }
    }
}