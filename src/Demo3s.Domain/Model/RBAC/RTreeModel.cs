using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Demo3s.Model.RBAC
{
    public class RTreeModel : BasicAggregateRoot<Guid>
    {
        public string TreeName { get; set; }  //名称
        public string TreeTid { get; set; } //递归外键
        public string TreeUrl { get; set; } //地址
    }
}
