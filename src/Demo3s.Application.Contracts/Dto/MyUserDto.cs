using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Demo3s.Dto
{
    public class MyUserDto : AuditedEntityDto<Guid>
    {
    
        public string Name { get; set; }
        
        public string Phone { get; set; }
       
        public string Address { get; set; }
    }
}
