using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Team.Model
{

    //城市表
    [Table("CityModel")]
    public   class CityModel:BaseModel
    {
        [Key]
        public Guid CityId { get; set; } = Guid.NewGuid(); //主键
        public string CityName { get; set; }//城市名称
        public string CityTid { get; set; }//外键


    }
}
