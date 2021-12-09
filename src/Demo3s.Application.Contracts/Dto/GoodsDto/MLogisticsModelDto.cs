using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo3s.Dto.GoodsDto
{
    /// <summary>
    /// 物流表 单独的
    /// </summary>
    public class MLogisticsModelDto : AuditedEntityDto<Guid>
    {
        public string LogisticsName { get; set; } //地址

        public DateTime CreateTime { get; set; } //时间
        public string Detail { get; set; }  //详情
    }
}
