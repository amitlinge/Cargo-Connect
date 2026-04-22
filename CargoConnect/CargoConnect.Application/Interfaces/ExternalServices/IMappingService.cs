using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.Interfaces.ExternalServices
{
    public interface IMappingService
    {
        TDest Map<TSource,TDest>(TSource source);

        List<TDest> MapList<TSource,TDest>(List<TSource> sources);
    }
}
