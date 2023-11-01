using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        public ValuableRepository ValuableRepository { get; set; }

        public Controller()
        {
            
        }

        public void AddToList(IValuable valuable)
        {
            ValuableRepository.AddValuable(valuable);
        }
    }
}
