using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Infraestructure.Mapper
{
    public class Parser
    {
        private readonly IMapper _mapper;
        public Parser(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public TResult Parse<TResult, TIn>(TIn value)
        {
            return _mapper.Map<TResult>(value);
        }
    }
}
