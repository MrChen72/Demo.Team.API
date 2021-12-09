using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo3s.Dto.CreateUpdateRBACDto
{
    public class CreateUpdateRPowerModelDto
    {
        [Required]
        public string PowerName { get; set; }  //名称
        [Required]
        public string PowerDetail { get; set; } //详情
    }
}
