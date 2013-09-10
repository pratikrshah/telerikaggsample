using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikAggregateSampleApp
{
    public class CommonViewModel
    {
        public ObservableCollection<PersonModel> stats { get; set; }
        public int TotalNumOfPeople { get; set; }       //Want the Aggregate function of telerik to save to these properties
        public int TotalNumberOfSkills { get; set; }    //Want the Aggregate function of telerik to save to these properties
        public int AvgNumberOfSkills { get; set; }      //Want the Aggregate function of telerik to save to these properties

        public CommonViewModel()
        {
            stats = new ObservableCollection<PersonModel>();
            stats.Add(new PersonModel()
            {
                Name = "A",
                Skills = 3
            });
            stats.Add(new PersonModel()
            {
                Name = "B",
                Skills = 5
            });
        }
    }
}
