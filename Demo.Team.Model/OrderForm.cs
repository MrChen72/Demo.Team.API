using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{
    //订单表
    [Table("Orderform")]
   public   class OrderForm : BaseModel
    {
        [Key]
        public Guid OrderFormId { get; set; } = Guid.NewGuid();  //主键
        public int GoodsName { get; set; } //商品姓名
        public string CityProvince { get; set; } //省
        public string City { get; set; }  //市
        public string CityDistrict { get; set; }//区
        public string CityDetail { get; set; } //地址详情
        public string Consignee { get; set; }//收货人
        public string Phone { get; set; }//用户联系电话
        public string GoodsDetail { get; set; }//商品详情
        public string GoodsImg { get; set; }//商品图片

    }
}
