using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Entity
{
    public class City
    {
        /// <summary>
        /// 城市ID
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// 所属省份ID
        /// </summary>
        public int ProviceId { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// 所属城市
        /// </summary>
        public Provice ProviceData { get; set; }
    }
}
