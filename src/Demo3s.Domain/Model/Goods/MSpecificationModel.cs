using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo3s.Model.Goods
{
    /// <summary>
    /// 类别表 
    /// </summary>
    public class MSpecificationModel : BasicAggregateRoot<Guid>
    {
        public string SpecificationName { get; set; } //规格值
    }
}
