using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo3s.Model.Goods
{
    /// <summary>
    /// 商品表 
    /// </summary>
    public class MGoodsModel : BasicAggregateRoot<Guid>
    {
        public int Specification { get; set; }  //规格外键

        public string GoodsName { get; set; }  //商品名称
        public decimal GoodsPrice { get; set; }  //商品价格
        public string GoodsImg { get; set; }  //商品图片
        public string GoodsImgTid { get; set; } //图片外键
        public string GoodsParticulars { get; set; }  //商品详情
        public string GoodsInventory { get; set; }  //商品库存


        public int GoodsState { get; set; }  //商品状态
        public string GoodsTid { get; set; }  //商品外键
        public string GoodsCategoryTid { get; set; } //种类

        public string GoodssPecification { get; set; } //规格规格
    }
}
