using MongoDB.Driver;

namespace la_cantina_backend.Models
{
    //Singleton class
    public class Database
    {
        private static Database? _instance;

        private string Name;
        private string Adress;
        private int Port;

        public MongoClient Client { get; set; }

        private Database(string name, string adress, int port)
        {
            Name = name;
            Adress = adress;
            Port = port;

            var connectionString = generateConnectionString();
            Client = new MongoClient(connectionString);

        }

        public static Database GetInstance(){
            if (_instance == null)
                _instance = new Database("la-cantina", "localhost", 27017);
            return _instance;
        }
         
        private void Connect()
        {
            //TODO : connexion bd mongo
        }

        private string generateConnectionString()
        {
            return "mongodb://" + Adress + ":" + Port;
        }
    }
}
