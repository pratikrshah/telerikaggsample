using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikAggregateSampleApp
{
    class MainWindowViewModel
    {
        public CommonViewModel UCVM { get; set; }

        public MainWindowViewModel()
        {
            UCVM = new CommonViewModel();
        }
    }
}
