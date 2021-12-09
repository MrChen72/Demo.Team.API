using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo3s.Model.Goods
{
    /// <summary>
    /// 物流表 单独的
    /// </summary>
    public class MLogisticsModel : BasicAggregateRoot<Guid>
    {
        public string LogisticsName { get; set; } //地址

        public DateTime CreateTime { get; set; } //时间
        public string Detail { get; set; }  //详情
    }
}
