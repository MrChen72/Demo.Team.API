using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo3s.Dto.CreateUpdateRBACDto
{
    public class CreateUpdateRUserRoleModelDto
    {
        [Required]
        public string UserId { get; set; }//用户外键
        public string RoleId { get; set; }//角色外键
    }
}
