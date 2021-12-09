using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo3s.Model.Goods
{
    /// <summary>
    /// 图片表
    /// </summary>/联查
    public class MFileImg : BasicAggregateRoot<Guid>
    {

        public string ImgUrl { get; set; } //图片路径
    }
}
