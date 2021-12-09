using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo3s.Dto.GoodsDto
{
    /// <summary>
    /// 地址表  三级联动 用于添加收货人地址
    /// </summary>
    public class MCityModelDto : AuditedEntityDto<Guid>
    {
        public string CityName { get; set; } //城市名称
        public string CityTid { get; set; } //外键
    }
}
