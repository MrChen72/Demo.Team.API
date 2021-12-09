using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo3s.Dto.GoodsDto
{
    /// <summary>
    /// 商品表 
    /// </summary>
    public class MGoodsModelDto : AuditedEntityDto<Guid>
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
