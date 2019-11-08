using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common_DogShow.BreedGroups;
using Common_DogShow;

namespace DataAccess_DogShow
{
    public class PullSqlData
    {
        public IEnumerable<string> BreedNames(Classes breedClass)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "select `Description` from `Breeds` where `ClassID` = @0; ";

                var results = db.Fetch<string>(sql, (int) breedClass);
                return results;
            }
        }
        public int BreedNum(string breedName)
        {

            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "select `BreedID` from `Breeds` where `Description` = @0; ";

                var results = db.Fetch<int>(sql, breedName);
                return results.FirstOrDefault();
            }
  
        }
        public void InsertDoggo(int breedID, string name, string lastName, string gender)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "INSERT INTO `Dog` (`BreedID`, `DogName`, `dogLastName`, `DogGender`) VALUES (@0, @1, @2, @3); ";

                db.Execute(sql, breedID, name, lastName, gender);

            }

        }


        public List<DogBreed> GetDogBreed()
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "SELECT a.`dogID`, a.`DogName`, a.`DogGender`, a.`BreedID`, b.`classID`, b.`description` FROM `dog` as `a` join `breeds` as `b` on a.`breedID` = b.`breedID`;";

                var results = db.Fetch<DogBreed>(sql);
                return results;
            }
        }
        public List<Dog> GetDogsForCompetition(int ClassID, int eventNum, int locationId)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "SELECT a.`dogID`, a.`DogName`, a.`DogLastName`, a.`BreedID`, b.`ClassID`, b.`description` FROM `dog` as `a` join `breeds` as `b` on a.`breedID` = b.`breedID` join `events_table` as c on a.`dogId` = c.`dogId` WHERE b.`ClassID` = @0 AND c.`eventNum` = @1 AND c.`location` = @2;";

                var results = db.Fetch<Dog>(sql, ClassID, eventNum, locationId);
                return results;
            }
        }
        public List<Dog> GetDogsForJudgement(int classId)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "SELECT a.`dogID`, a.`DogName`, a.`DogLastName`, a.`BreedID`, b.`ClassID`, b.`description` FROM `dog` as `a` join `breeds` as `b` on a.`breedID` = b.`breedID` WHERE b.`ClassID` = @0;";

                var results = db.Fetch<Dog>(sql, classId);
                return results;
            }
        }
        public List<string> GetDogLastName()
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "SELECT a.`dogLastName` FROM `dog` as `a` join `breeds` as `b` on a.`breedID` = b.`breedID`;";

                var results = db.Fetch<string>(sql);
                return results;
            }
        }
        
        public int DogId(string dogName, string dogLastName)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "select `dogID` from `dog` where `dogName` = @0 AND dogLastName = @1; ";

                var results = db.Fetch<int>(sql, dogName, dogLastName);
                return results.FirstOrDefault();
            }
        }

        public void InsertScores(int total, int size, int eyeColor, int furColor, int furLength, int DogId)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "INSERT INTO `scores` (`totalScore`, `Size`, `EyeColor`, `FurColor`, `FurLength`, `DogID`) VALUES (@0, @1, @2, @3, @4, @5); ";

                db.Execute(sql, total, size, eyeColor, furColor, furLength, DogId);

            }
        }
        public void InsertEvent(int locationID, int eventNum, int dogID, string time)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "INSERT INTO `Events_Table` (`location`, `eventNum`, `dogID`, `eventTime`) VALUES (@0, @1, @2, @3); ";

                db.Execute(sql, locationID, eventNum, dogID, time);

            }
        }

        public List<string> OrderDogs(int classID, int scoreIDOne, int scoreIDTwo, int scoreIDThree)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "SELECT a.`DogName` from `dog` a join `scores` as b on a.`dogId` = b.`dogId` join `breeds` as c on a.`breedId` = c.`breedId` where c.`classID` = @0 and b.`ScoreID` = @1  or b.`scoreID` = @2 or b.`scoreID` = @3 order by b.`totalScore` desc;";

                var results = db.Fetch<string>(sql, classID, scoreIDOne, scoreIDTwo, scoreIDThree);
                return results;
            }
        }

        public int EventID(int dogId)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "select a.`eventID` from `events_table` as `a` join `dog` as `b` where a.`dogID` = b.`dogId` AND b.`dogId` = @0; ";

                var results = db.Fetch<int>(sql, dogId);
                return results.FirstOrDefault();
            }
        }
        public int ScoreID(int dogId)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "select a.`scoreID` from `scores` as `a` join `dog` as `b` where a.`dogID` = b.`dogId` AND a.`dogID` = @0; ";

                var results = db.Fetch<int>(sql, dogId);
                return results.FirstOrDefault();
            }
        }
        public void InsertCompetition(int eventId, int placement, int dogID, int scoreID)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "INSERT INTO `competitions` (`EventID`, `Placement`, `DogID`, `scoreID`) VALUES (@0, @1, @2, @3); ";

                db.Execute(sql, eventId, placement, dogID, scoreID);

            }
        }
        public List<int> OrderDogIds(int classId, int idOne, int idTwo, int idThree, int eventNum, int locationId)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "SELECT DISTINCT a.`dogId` FROM `dog` as a join `events_table` as b on a.`dogId` = b.`dogID` join `breeds` as c join `scores` as d on d.`dogId` = b.`dogId` WHERE c.`classID` = @0 AND b.`eventNum` = @1 AND b.`Location` = @2 AND a.`dogId` = @3 OR a.`dogId` = @4 OR a.`DogId` = @5 ORDER BY d.`totalScore` desc";

                var results = db.Fetch<int>(sql, classId, eventNum, locationId, idOne, idTwo, idThree);
                return results;
            }
        }
        public List<string> PastCompetitionDoggos(int classID, int eventNum, int locationId, string time)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "SELECT DISTINCT a.`dogname` from `dog` as a join `events_table` as b on a.`dogId` = b.`dogId` join `competitions` as c on b.eventId = c.`eventId` join `breeds` as d where d.`classId` = @0 and b.`eventNum` = @1 and b.`eventtime` = @2 and b.`location` = @3 order by c.`placement` asc;";

                var results = db.Fetch<string>(sql, classID, eventNum, time, locationId);
                return results;
            }
        }
    }
}
