using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{
    //权限表
    public  class PowerModel : BaseModel
    {
        public Guid PowerId { get; set; } = Guid.NewGuid(); //主键
        public string PowerName { get; set; }  //名称
        public string PowerDetail { get; set; } //详情


    }
}
