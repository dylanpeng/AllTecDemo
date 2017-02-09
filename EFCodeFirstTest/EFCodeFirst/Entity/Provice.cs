using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Entity
{
    public class Provice
    {
        /// <summary>
        /// 省份ID
        /// </summary>
        public int ProviceId { get; set; }

        /// <summary>
        /// 省份名
        /// </summary>
        public string ProviceName { get; set; }

        /// <summary>
        /// 省份下城市
        /// </summary>
        public List<City> Citys { get; set; }
    }
}
