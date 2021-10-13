using System;
using System.Collections.Generic;
using System.Linq;
using Vehicles.API.Data;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Services
{
    public class MenuMasterService : IMenuMasterService
    {

        private readonly DataContext _context;

        public MenuMasterService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<MenuMaster> GetMenuMaster()
        {
            return _context.MenuMaster.AsEnumerable();
        }
    }
}
