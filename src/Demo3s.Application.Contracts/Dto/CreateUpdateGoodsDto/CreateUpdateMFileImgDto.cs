using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo3s.Dto.CreateUpdateGoodsDto
{
    /// <summary>
    /// 图片表
    /// </summary>/联查
    public class CreateUpdateMFileImgDto
    {
        [Required]
        public string ImgUrl { get; set; } //图片路径
    }
}
