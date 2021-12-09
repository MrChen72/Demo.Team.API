using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo3s.Dto.CreateUpdateGoodsDto
{
    /// <summary>
    /// 物流表 单独的
    /// </summary>
    public class CreateUpdateMLogisticsModelDto
    {
        [Required]
        public string LogisticsName { get; set; } //地址

        public DateTime CreateTime { get; set; } //时间
        public string Detail { get; set; }  //详情
    }
}
