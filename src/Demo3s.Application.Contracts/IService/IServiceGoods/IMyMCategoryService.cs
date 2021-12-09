using Demo3s.Dto.CreateUpdateGoodsDto;
using Demo3s.Dto.GoodsDto;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Demo3s.IService.IServiceGoods
{
    public interface IMyMCategoryService : ICrudAppService<MCategoryModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMCategoryModelDto>
    {
    }
}
