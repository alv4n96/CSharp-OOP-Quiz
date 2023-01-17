using JuraganMobil.Collection;
using JuraganMobil.Repository;
using JuraganMobil.Repository.SUV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Base
{
    internal interface IRepositoryManager
    {
        public ISummary Master { get; }

        public ISUVRepository SUV { get; }
    }
}
