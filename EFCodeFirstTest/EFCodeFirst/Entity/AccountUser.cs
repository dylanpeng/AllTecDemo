using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst.Entity
{
    [Table("user")]
    public class AccountUser
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Column("ID")]
        public int AccountUserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public Nullable<int> Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public Nullable<bool> Sex { get; set; }

    }
}
