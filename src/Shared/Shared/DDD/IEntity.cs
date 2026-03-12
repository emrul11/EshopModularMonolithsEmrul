using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DDD
{
    public interface IEntity<T> : IEntity
    {
        public T Id { get; set; }
    }

    public interface IEntity
    {
        public DateTime CreateAt { get; set; }
        public String? CreateBy { get; set; }
        public DateTime LastModifiedAt { get; set; }
        public String? LastModifiedBy { get; set; }

    }
}
