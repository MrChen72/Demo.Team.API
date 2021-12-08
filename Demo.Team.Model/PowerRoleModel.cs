using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{
    //权限角色表
    [Table("PowerRoleModel")]
    public class PowerRoleModel : BaseModel
    {
        [Key]
        public Guid PowerRoleId { get; set; } = Guid.NewGuid(); //主键
        public string PowerId { get; set; } //权限表
        public string RoleId { get; set; }//角色表

    }
}
