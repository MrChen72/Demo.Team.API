using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo3s.Dto.CreateUpdateRBACDto
{
    public class CreateUpdateRPowerRoleModelDto
    {
        [Required]
        public string PowerId { get; set; } //权限表
        [Required]
        public string RoleId { get; set; }//角色表
    }
}
