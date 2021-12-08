using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{
    //用户角色表
    [Table("UserRoleModel")]
   public  class UserRoleModel:BaseModel
    {
        [Key]
        public Guid UserRoleId { get; set; } = Guid.NewGuid();//主键
        public string UserId { get; set; }//用户外键
        public string RoleId { get; set; }//角色外键

    }
}
