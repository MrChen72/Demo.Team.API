using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Demo3s.Dto.CreateUpdateRBACDto
{
    public class CreateUpdateRUserModelDto
    {
        [Required]
        public string UserName { get; set; }   //用户姓名
        public int UserSex { get; set; }  //用户性别
        public string UserAccount { get; set; }  //用户账号
        public string UserPwd { get; set; }//用户密码  需要用到MD5加密
        public string UserHeadPortrait { get; set; }//用户头像
        public int UserAge { get; set; }//用户年龄

        public bool UserState { get; set; } //用户状态
    }
}
