using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{
    //购物车表
    public class ShoppingModel : BaseModel
    {
     
        public Guid ShoppingId { get; set; } = Guid.NewGuid(); //购物车主键
        public string GoodsId { get; set; }  //商品的主键
        public string GoodsName { get; set; }//商品名称
        public float GoodsPrice { get; set; }//商品价格
        public string GoodsImg { get; set; }//商品图片
        public string GoodsDetail { get; set; }//商品详情
        public int GodosSum { get; set; }//商品库存
        public string SpecificationId { get; set; }//规格外键

    }
}
