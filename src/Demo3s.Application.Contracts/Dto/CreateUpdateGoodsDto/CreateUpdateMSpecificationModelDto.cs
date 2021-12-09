using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo3s.Dto.CreateUpdateGoodsDto
{
    /// <summary>
    /// 类别表 
    /// </summary>
    public class CreateUpdateMSpecificationModelDto
    {
        [Required]
        public string SpecificationName { get; set; } //规格值
    }
}
