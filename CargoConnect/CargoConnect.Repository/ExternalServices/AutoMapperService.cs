using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CargoConnect.Application.Interfaces.ExternalServices;

namespace CargoConnect.Infrastructure.ExternalServices
{
    public class AutoMapperService : IMappingService
    {
        IMapper _mapper;

        public AutoMapperService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TDest Map<TSource, TDest>(TSource source)
        {
            return _mapper.Map<TDest>(source);
        }

        public List<TDest> MapList<TSource, TDest>(List<TSource> sources)
        {
            return _mapper.Map<List<TDest>>(sources);
        }
    }
}
