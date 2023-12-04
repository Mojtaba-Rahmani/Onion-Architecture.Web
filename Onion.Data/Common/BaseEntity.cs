using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Data.Common
{
    /// <summary>
    /// value Object Class
    /// 
    /// can do : 
    /// last modifire , ....
    /// </summary>
    public abstract class BaseEntity 
    {
        [Key]
        public int Id { get; set; }
    }
}
