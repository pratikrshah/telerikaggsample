using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikAggregateSampleApp
{
    public class PersonModel
    {
        private string name;
        private int skills;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Skills
        {
            get
            {
                return skills;
            }
            set
            {
                skills = value;
            }
        }
    }
}
