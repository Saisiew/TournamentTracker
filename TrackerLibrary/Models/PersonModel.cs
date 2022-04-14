using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the First Name of a Person on a team
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents the Last Name of a Person on a team
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the Email Address of a Person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the Cellphone Number of a Person
        /// </summary>
        public string CellPhoneNumber { get; set; }

        public string FullName
        {
            get 
            { 
                return $"{ FirstName } { LastName }"; 
            }
            
        }

    }
}
