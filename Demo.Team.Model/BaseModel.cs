using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{
    [Table("BaseModel")]
    //基础表
    public  class BaseModel
    {
        [Key]
        public Guid BaseId { get; set; } = Guid.NewGuid();//基础表id
        public DateTime CreateTime { get; set; } = DateTime.Now; //创建时间
        public int CreateUserId { get; set; } //创建人
        public DateTime UpDateTime { get; set; } //修改时间
        public int UpDaeUserId { get; set; }//修改人
        public DateTime DeleteTime { get; set; }//删除时间
        public int DeleteUserId { get; set; }//删除人
        //逻辑删除
        public int State { get; set; } //状态  默认为0     state=1 为删除

    }
}
