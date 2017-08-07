using CitiesWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesWebApi
{
    public class Reposotory
    {
        public static Reposotory Current { get; } = new Reposotory();
        public List<CityModel> Cities;

        public Reposotory()
        {
            Cities = new List<CityModel>() {
                new CityModel
                {
                    Id = 1,
                    Name = "Riyadh",
                    States = new List<PointOfInterstModel>
                    {
                        new PointOfInterstModel
                        {
                            Id = 1,
                            Name = "Elmamlaka Tower"
                        },
                        new PointOfInterstModel
                        {
                            Id = 2,
                            Name = "Elfaysaleya Tower"
                        }
                    }
                },
                new CityModel
                {
                    Id = 2,
                    Name = "Dubai",
                    States=new List<PointOfInterstModel>
                    {
                        new PointOfInterstModel
                        {
                            Id = 3,
                            Name = "Burj Khalifa"
                        },
                        new PointOfInterstModel
                        {
                            Id = 4,
                            Name = "Jumira Beach"
                        }
                    }
                }
            };
        }
    }
}
