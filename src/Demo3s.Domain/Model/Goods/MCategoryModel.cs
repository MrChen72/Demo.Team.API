using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo3s.Model.Goods
{
    /// <summary>
    /// 种类表  联查
    /// </summary>
    public class MCategoryModel : BasicAggregateRoot<Guid>
    {

        public string MCategoryName { get; set; } //种类
    }
}
