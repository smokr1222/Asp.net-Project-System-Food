
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace systemFood.Models
{
    public class OrderItems
    {
        [Key]
        public int OrderItemId { get; set; } // معرف فريد لعنصر الطلب (إذا أردت تتبع كل سطر في الطلب)
        [ForeignKey("Order")]
        public string OrderId { get; set; } = string.Empty; // معرف الطلب الأب (المفتاح الخارجي لربط عنصر الطلب بالطلب الرئيسي)
        public Orders Order { get; set; } = default!;
        [ForeignKey("Product")]
        public int ProductId { get; set; } // معرف المنتج من قائمة المنتجات (لربطه بالمنتج الأصلي)
        public Product Product { get; set; } = default!;
        public int Quantity { get; set; } // الكمية المطلوبة من هذا المنتج
        public decimal UnitPrice { get; set; } // سعر الوحدة الأساسي للمنتج

        public DateTime DateTime { get; set; }= DateTime.Now;


        public string? Size { get; set; } // الحجم المختار (مثال: "small", "medium", "large")
        public string? Note { get; set; } // ملاحظات خاصة لهذا العنصر في الطلب (مثال: "بدون بصل")

        // خاصية محسوبة (ليست مخزنة في قاعدة البيانات عادةً) لسهولة الوصول
        // هذا السعر يشمل سعر الوحدة + تكلفة الإضافات + تأثير الحجم
        [NotMapped]
        public decimal CalculatedPricePerUnit { get; set; } // السعر المحسوب لوحدة واحدة من هذا العنصر (يشمل الإضافات والحجم)

        // خاصية محسوبة أخرى
        public decimal TotalPrice => Quantity * CalculatedPricePerUnit; // السعر الإجمالي لهذا العنصر (الكمية * السعر المحسوب للوحدة)

        public ICollection<SelectExtrasProduct> selectExtra { get; set; }
        public decimal? TotalPriceExtra => (selectExtra.Sum(x=>x.Extras.Price)); // السعر الإجمالي لهذا العنصر (الكمية * السعر المحسوب للوحدة)


    }




}

