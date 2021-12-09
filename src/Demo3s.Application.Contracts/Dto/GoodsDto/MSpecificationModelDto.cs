using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo3s.Dto.GoodsDto
{
    /// <summary>
    /// 类别表 
    /// </summary>
    public class MSpecificationModelDto : AuditedEntityDto<Guid>
    {
        public string SpecificationName { get; set; } //规格值
    }
}
