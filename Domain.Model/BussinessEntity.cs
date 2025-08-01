using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public abstract class BussinessEntity
    {
        public int Id { get; set; }
        public void SetId(int id)
        {
            if (int.IsNegative(id))
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            Id = id;
        }

    }
}
