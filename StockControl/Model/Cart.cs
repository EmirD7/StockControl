using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockControl.Model
{
    [Table("Cart")]
    public class Cart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
    }
}
