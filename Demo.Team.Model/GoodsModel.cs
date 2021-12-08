using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{
    //商品表
   public  class GoodsModel : BaseModel
    {
        public Guid GoodsId { get; set; } = Guid.NewGuid(); //商品主键
        public string SpecificationId { get; set; }//规格外键
        public string GoodsName { get; set; }//商品名称
        public float GoodsPrice { get; set; }//商品价格
        public string GoodsImg { get; set; }//商品图片
        public string GoodsDetail { get; set; }//商品详情
        public int GoodsSum { get; set; }//商品库存

    }
}
