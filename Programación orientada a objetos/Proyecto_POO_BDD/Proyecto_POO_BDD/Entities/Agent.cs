namespace Proyecto_POO_BDD.Entities
{
    public class Agent
    {
        public int id { get; set; }
        
        public string name { get; set; }

        public string eMail { get; set; }
        
        public string user { get; set; }
        
        public int password { get; set; }


        public Agent()
        {
            
        }

        public Agent(string name, string eMail, string user, int password)
        {
            this.name = name;
            this.eMail = eMail;
            this.user = user;
            this.password = password;
        }
    }
}