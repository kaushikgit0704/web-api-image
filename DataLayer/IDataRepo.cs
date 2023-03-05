using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDataRepo
    {
        public IEnumerable<WeatherForecast> Get();
    }
}
