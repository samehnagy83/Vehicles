using System.Collections.Generic;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Services
{
    internal interface IMenuMasterService
    {
        IEnumerable<MenuMaster> GetMenuMaster();
    }
}
