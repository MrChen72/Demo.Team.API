using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo3s.Dto.CreateUpdateGoodsDto
{
    /// <summary>
    /// 种类表  联查
    /// </summary>
    public class CreateUpdateMCategoryModelDto
    {
        [Required]
        public string MCategoryName { get; set; } //种类
    }
}
