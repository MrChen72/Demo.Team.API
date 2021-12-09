using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo3s.Dto.CreateUpdateRBACDto
{
    public class CreateUpdateRRoleModelDto
    {
        [Required]
        public string RoleName { get; set; } //名称
        [Required]
        public string RoleDetail { get; set; }//详情
    }
}
