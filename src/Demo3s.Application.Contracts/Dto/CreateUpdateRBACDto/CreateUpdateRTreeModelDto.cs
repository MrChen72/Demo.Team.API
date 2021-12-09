using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo3s.Dto.CreateUpdateRBACDto
{
    public class CreateUpdateRTreeModelDto
    {
        [Required]
        public string TreeName { get; set; }  //名称
        [Required]
        public string TreeTid { get; set; } //递归外键
        public string TreeUrl { get; set; } //地址
    }
}
