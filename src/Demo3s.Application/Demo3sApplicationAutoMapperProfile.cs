using AutoMapper;
using Demo3s.Dto;
using Demo3s.Dto.CreateUpdateGoodsDto;
using Demo3s.Dto.GoodsDto;
using Demo3s.Model.Goods;
using Demo3s.Model.MyData;

namespace Demo3s
{
    public class Demo3sApplicationAutoMapperProfile : Profile
    {
        public Demo3sApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<MyUserModel, MyUserDto>();
            CreateMap<CreateUpdateMyUserDto, MyUserModel>();

            #region
            //Goods
            CreateMap<MCategoryModel, MCategoryModelDto>();
            CreateMap<CreateUpdateMCategoryModelDto, MCategoryModel>();

            #endregion
        }
    }
}
