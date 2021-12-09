using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo3s.Model.Goods
{
    /// <summary>
    /// 购物车  
    /// </summary>
    public class MShoppingModel : BasicAggregateRoot<Guid>
    {
        public string GoodsName { get; set; }//商品名称
        public float GoodsPrice { get; set; }//商品价格
        public string GoodsImg { get; set; }//商品图片
        public string GoodsDetail { get; set; }//商品详情
        public int State { get; set; }//商品状态  
        public string Specificationid { get; set; } //商品规格
    }
}
