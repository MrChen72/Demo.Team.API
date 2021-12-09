﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo3s.Model.RBAC
{
    public class RPowerRoleModel : BasicAggregateRoot<Guid>
    {
        public string PowerId { get; set; } //权限表
        public string RoleId { get; set; }//角色表
    }
}
