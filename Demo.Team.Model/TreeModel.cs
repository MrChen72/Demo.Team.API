using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{
    //权限树
    public class TreeModel:BaseModel
    {
        public Guid TreeId { get; set; } = Guid.NewGuid(); //主键
        public string TreeName { get; set; }  //名称
        public string TreeTid { get; set; } //递归外键

    }
}
