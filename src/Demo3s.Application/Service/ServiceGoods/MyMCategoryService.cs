using Demo3s.Dto.CreateUpdateGoodsDto;
using Demo3s.Dto.GoodsDto;
using Demo3s.Model.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Demo3s.Service.ServiceGoods
{
    public class MyMCategoryService : CrudAppService<MCategoryModel, MCategoryModelDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateMCategoryModelDto>
    {
        public MyMCategoryService(IRepository<MCategoryModel, Guid> mCategoryModels) : base(mCategoryModels) { }
    }
}
