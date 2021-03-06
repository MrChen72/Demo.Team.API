using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{
    
    //用户表
   public  class UserModel : BaseModel
    {
        public Guid UserId { get; set; } = Guid.NewGuid(); //用户主键
        public string UserName { get; set; }   //用户姓名
        public int UserSex { get; set; }  //用户性别
        public string UserAccount { get; set; }  //用户账号
        public string UserPwd { get; set; }//用户密码  需要用到MD5加密
        public string UserNickname { get; set; }//用户昵称
        public string UserHeadPortrait { get; set; }//用户头像
        public int UserAge { get; set; }//用户年龄

    }
}
