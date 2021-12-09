using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo3s.Dto.GoodsDto
{
    /// <summary>
    /// 种类表  联查
    /// </summary>
    public class MCategoryModelDto : AuditedEntityDto<Guid>
    {
        public string MCategoryName { get; set; } //种类
    }
}
