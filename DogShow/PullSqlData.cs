using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DogShow
{
    class PullSqlData
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
        public void InsertDoggo(int breedID, string name, string gender)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "INSERT INTO `Dog` (`BreedID`, `DogName`, `DogGender`) VALUES (@0, @1, @2); ";

                db.Execute(sql, breedID, name, gender);

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
        
        public int DogIdNum(string dogName)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "select `dogID` from `dog` where `dogName` = @0; ";

                var results = db.Fetch<int>(sql, dogName);
                return results.FirstOrDefault();
            }
        }

        public void InsertScores(int total, int size, int eyeColor, int furColor, int furLength, int DogId)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "INSERT INTO `scores` (`ScoreID`, `Size`, `EyeColor`, `FurColor`, `FurLength`, `DogID`) VALUES (@0, @1, @2, @3, @4, @5); ";

                db.Execute(sql, total, size, eyeColor, furColor, furLength, DogId);

            }
        }
        public void InsertEvent(int locationID, int eventNum)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "INSERT INTO `Events_Table` (`location`, `eventNum`) VALUES (@0, @1); ";

                db.Execute(sql, locationID, eventNum);

            }
        }
        public List<string> RegisteredDogsInClass(int classId)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "select a.`DogName` from `dog` as `a` join `breeds` as `b` where a.`breedID` = b.`breedId` AND b.`classID` = @0; ";

                var results = db.Fetch<string>(sql, classId);
                return results;
            }
        }
        public List<string> OrderDogs(int classID, string dogOne, string dogTwo, string dogThree)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "SELECT a.`DogName` from `dog` a join `scores` as b on a.`dogId` = b.`dogId` join `breeds` as c on a.`breedId` = c.`breedId` where c.`classID` = @0 and a.`DogName` = @1 or a.`DogName` = @2 or a.`DogName` = @3 order by b.`scoreID` desc;";

                var results = db.Fetch<string>(sql, classID, dogOne, dogTwo, dogThree);
                return results;
            }
        }
        public int DogCompetitionId(string dogName)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "select a.`competitionID` from `scores` as `a` join `dog` as `b` where a.`dogID` = b.`dogId` AND b.`dogName` = @0; ";

                var results = db.Fetch<int>(sql, dogName);
                return results.FirstOrDefault();
            }
        }
        public int EventID(string dogName)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "select a.`eventID` from `events_table` as `a` join `dog` as `b` where a.`dogID` = b.`dogId` AND b.`dogName` = @0; ";

                var results = db.Fetch<int>(sql, dogName);
                return results.FirstOrDefault();
            }
        }
        public int ScoreID(string dogName)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "select a.`scoreID` from `scores` as `a` join `dog` as `b` where a.`dogID` = b.`dogId` AND b.`dogName` = @0; ";

                var results = db.Fetch<int>(sql, dogName);
                return results.FirstOrDefault();
            }
        }
        public void InsertCompetition(int eventId, int placement, int dogID, int scoreID)
        {
            using (var db = new Database("SERVER=agssqlw02;DATABASE=sabrarathbun;UID=sabrarathbun;PWD=Gam5I7zaNOw6Ydid;", "MySql.Data.MySqlClient"))
            {
                string sql = "INSERT INTO `competitions` (`EventID`, `Placement`, `DogID`, `ScoreID`) VALUES (@0, @1, @2, @3); ";

                db.Execute(sql, eventId, placement, dogID, scoreID);

            }
        }
    }
}
