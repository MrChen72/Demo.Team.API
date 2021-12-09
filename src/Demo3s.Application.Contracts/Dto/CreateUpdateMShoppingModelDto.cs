﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Demo3s.Dto
{
    /// <summary>
    /// 购物车  
    /// </summary>
    public class CreateUpdateMShoppingModelDto
    {

        public string GoodsName { get; set; }//商品名称
        public float GoodsPrice { get; set; }//商品价格
        public string GoodsImg { get; set; }//商品图片
        public string GoodsDetail { get; set; }//商品详情
        public int State { get; set; }//商品状态  
        public string Specificationid { get; set; } //商品规格
    }
}
