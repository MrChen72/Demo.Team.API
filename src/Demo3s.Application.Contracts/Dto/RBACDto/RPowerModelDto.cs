using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo3s.Dto.RBACDto
{
    public class RPowerModelDto : AuditedEntityDto<Guid>
    {
        public string PowerName { get; set; }  //名称
        public string PowerDetail { get; set; } //详情
    }
}
