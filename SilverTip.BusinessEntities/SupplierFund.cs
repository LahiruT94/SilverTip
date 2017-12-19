using SilverTip.BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boughtleaf.BusinessEntities
{
    public class SuppierFund
    {
        [Key]
        public int Id { get; set; }

        public Decimal Amount { get; set; }

        [ForeignKey("SupplierId")]
        public virtual ICollection<Supplier> Suppliers { get; set; }

        [ForeignKey("FundId")]
        public virtual ICollection<Fund> Funds { get; set; }

        [ForeignKey("FundModeId")]
        public virtual ICollection<FundMode> FundModes { get; set; }

    }
}
