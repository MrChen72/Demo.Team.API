using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{
    //角色表
    public class RoleModel:BaseModel
    {
        public Guid RoleId { get; set; } = Guid.NewGuid();  //角色表主键
        public string RoleName { get; set; } //名称
        public string RoleDetail { get; set; }//详情

    }
}
