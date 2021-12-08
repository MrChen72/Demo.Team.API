using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{
    //商品规格表
    [Table("SpecificationModel")]
  public   class SpecificationModel : BaseModel
    {
        [Key]
        public Guid SpecificationId { get; set; } = Guid.NewGuid();
        public string SpecificationName { get; set; } //规格名称
        public string SpecificationDetail { get; set; } //规格详情

    }
}
