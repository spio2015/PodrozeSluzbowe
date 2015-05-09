using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public partial class Cars
    {
        public string CmbCars { get { return string.Format("{0} {1} ({2})", Brand, Model, RegistrationNumber);}}
    }
}
