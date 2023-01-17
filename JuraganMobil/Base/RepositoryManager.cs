using JuraganMobil.Collection;
using JuraganMobil.Model;
using JuraganMobil.Repository;
using JuraganMobil.Repository.SUV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraganMobil.Base
{
    internal class RepositoryManager : IRepositoryManager
    {
        private ISummary? _masterRepository;
        private ISUVRepository? _sUVRepository;

        private IVehiclesCollection? _vehiclesCollection;


        //private List<Vehicle> _vehiclesCollection;

        public RepositoryManager(IVehiclesCollection collection)
        {
            _vehiclesCollection = collection;
        }


        public ISummary Master 
        { 
            get 
            {
                _masterRepository ??= new Summary(_vehiclesCollection);

                return _masterRepository;
            } 
        }

        public ISUVRepository SUV
        {
            get
            {
                _sUVRepository ??= new SUVRepository(_vehiclesCollection);
                return _sUVRepository;
            }
        }
    }
}
