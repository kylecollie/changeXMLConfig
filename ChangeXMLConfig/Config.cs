using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeXMLConfig
{
    class Config
    {
        public Boolean onlineInsp { get; set; }

        public Config()
        {
            this.onlineInsp = false;
        }

        public Config(Boolean oi)
        {
            this.onlineInsp = oi;
        }
    }
    
}
