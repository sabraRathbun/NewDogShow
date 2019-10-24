using System.Collections.Generic;
using DataAccess_DogShow;
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
