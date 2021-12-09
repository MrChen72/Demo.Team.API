using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo3s.Model.Goods
{
    /// <summary>
    /// 地址表  三级联动 用于添加收货人地址
    /// </summary>
    public class MCityModel : BasicAggregateRoot<Guid>
    {
        public string CityName { get; set; } //城市名称
        public string CityTid { get; set; } //外键
    }
}
