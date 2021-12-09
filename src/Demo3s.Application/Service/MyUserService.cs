using Demo3s.Dto;
using Demo3s.Model.MyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo3s.Service
{
    public class MyUserService: CrudAppService<MyUserModel,MyUserDto,Guid, PagedAndSortedResultRequestDto, CreateUpdateMyUserDto>
    {
        public MyUserService(IRepository<MyUserModel, Guid> myUserModels) : base(myUserModels) { }
    }
}
