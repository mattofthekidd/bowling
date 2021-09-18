using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace bowling.Commands.Games {
    public class GetGameByIdQuery : IRequest {
        public int GameId { get; set; } 
    }

    public class GetGameByIdHandler : IRequestHandler<GetGameByIdQuery> {
        //private readonly DBAccess

        //Constructor
        public GetGameByIdHandler() {

        }

        public Task<Unit> Handle(GetGameByIdQuery request, CancellationToken cancellationToken) {
            throw new NotImplementedException();
        }
    }
}
