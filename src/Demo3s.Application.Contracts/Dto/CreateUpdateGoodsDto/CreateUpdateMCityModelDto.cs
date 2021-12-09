using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo3s.Dto.CreateUpdateGoodsDto
{
    /// <summary>
    /// 地址表  三级联动 用于添加收货人地址
    /// </summary>
    public class CreateUpdateMCityModelDto
    {
        [Required]
        public string CityName { get; set; } //城市名称
        public string CityTid { get; set; } //外键
    }
}
