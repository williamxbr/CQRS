using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Aplication.Commands
{
    public class CriarUsuarioCommand: IRequest<CriarUsuarioCommandResponse>
    {
        public CriarUsuarioCommand()
        {

        }
    }
}
