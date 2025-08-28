
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace systemFood.Models
{
    public class Orders
    {
        [Key]
        public string OrderId { get; set; } = string.Empty; /*= $"#{Guid.NewGuid().ToString().Substring(0, 6)}";*/ // معرف فريد للطلب (مثال: #2021055)
        public DateTime OrderDate { get; set; } = DateTime.Now; // تاريخ ووقت إنشاء الطلب
        public string?PaymentMethod { get; set; } // طريقة الدفع (مثال: "Cash", "Visa", "InstaPay")
        public decimal? TotalAmount { get; set; } // المبلغ الإجمالي للطلب بعد الخصم والضرائب


        // قائمة بعناصر الطلب المرتبطة بهذا الطلب.
        // `OrderItem` هو نموذج منفصل سأقدمه لك بعد هذا.
       // public List<OrderItems> Items { get; set; } = new List<OrderItems>();
        public ICollection<OrderItems> Items { get; set; } = new List<OrderItems>();



    }
}
