using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    public class Actor
    {
        // Constructors Section
        
        public Actor()
        {
            Console.WriteLine("An actor is born.");
            // this.CurrentAgency = new Agency();
        }

        public Actor(string actorName)
            : this()
        {
            ActorName = actorName;
        }

        // Properties Section
        
        private string actorName;

        public string ActorName
        {
            get { return actorName; }
            set 
            {
                var formattedName = value?.Trim();
                actorName = formattedName;
            }
        }

        public string JobTitle { get; set; }

        public int ActorAge { get; set; }

        public string ActorDescription { get; set; } = "Regular Actor";

        private Agency currentAgency;

        public Agency CurrentAgency
        {
            get
            {
                if (currentAgency == null)
                    currentAgency = new Agency();
                return currentAgency;
            }
            set { currentAgency = value; }
        }


        // Methods Section

        /// <summary>
        /// Will return title
        /// </summary>
        /// <returns>Take no params</returns>
        public string GetOccupation()
        {
            JobTitle = "Actor";
            return JobTitle;
        }

        /// <summary>
        /// Books actor and not date specified
        /// </summary>
        public string BookActor()
        {
            //string details = "Booking can change if actor starts trouble";
            //return $"Actor {ActorName} is booked. {details}";
            return BookActor(string.Empty);
        }

        /// <summary>
        /// Books actor on specific date
        /// </summary>
        /// <param name="theDate"></param>
        public string BookActor(string theDate)
        {
            string details = "Booking can change if actor starts trouble";
            string theActor = $"Actor {ActorName} is booked";
            if(theDate != string.Empty)
            {
                return $"{theActor} on {theDate}. {details}";
            }
            else
                return $"{theActor}. {details}";
        }

        /// <summary>
        /// Get the actors agency
        /// </summary>
        /// <returns></returns>
        public string GetAgency()
        {
            // var currentAgency = new Agency();
            return CurrentAgency.Name;
        }
    }
}
