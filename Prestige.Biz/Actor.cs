using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
    public class Actor
    {
        private string jobTitle;

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
        
        /// <summary>
        /// Will return title
        /// </summary>
        /// <returns>Take no params</returns>
        public string GetOccupation()
        {
            JobTitle = "Actor";
            return JobTitle;
        }
    }
}
