using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess_DogShow;
using System.Windows.Forms;
using Common_DogShow;

namespace Service_DogShow
{
    public class Registered
    {
        List<DogBreed> DogList = new List<DogBreed>();
        PullSqlData pull = new PullSqlData();

        public List<DogBreed> GetDogList()
        {
            DogList = pull.GetDogBreed();
            return DogList;
        }
    }
}
