using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Database;

namespace PodrozeSluzbowe.BusinessClasses
{
    class TravelsGrid
    {
        private int tripId;
        private string userName;
        private string address;
        private string registrationNumber;
        private DateTime departureDate;
        private DateTime arrivalDate;

	    public int TripId
	    {
		    get { return tripId;}
		    set { tripId = value;}
	    }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }
        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }
    }
}
