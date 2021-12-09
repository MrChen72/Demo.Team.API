using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo3s.Dto.RBACDto
{
    public class RUserRoleModelDto : AuditedEntityDto<Guid>
    {
        public string UserId { get; set; }//用户外键
        public string RoleId { get; set; }//角色外键
    }
}
