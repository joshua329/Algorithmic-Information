using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algorithmic_Information.src
{
    class Main {
        public Thread NewsInfo;
        public void Start() {
            NewsInfo = new Thread(new Algorithmic_Information.Data_sources.NewsSites().Start);
        }
    }
}
