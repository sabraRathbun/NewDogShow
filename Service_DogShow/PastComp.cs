using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_DogShow;
using DataAccess_DogShow;

namespace Service_DogShow
{
    public class PastComp
    {
        PullSqlData pull = new PullSqlData();
        List<string> orderedDogs = new List<string>();

        public List<string> OrderedDoggos(int breedIndex, int eventNum, int locationID, string time)
        {
            orderedDogs = pull.PastCompetitionDoggos(breedIndex, eventNum, locationID, time);
            return orderedDogs;
        }
    }
}
