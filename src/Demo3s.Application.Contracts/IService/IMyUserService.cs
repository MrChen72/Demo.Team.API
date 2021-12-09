using Demo3s.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo3s.IService
{
    public interface IMyUserService : ICrudAppService<MyUserDto,Guid, PagedAndSortedResultRequestDto, CreateUpdateMyUserDto>
    {
    }
}
