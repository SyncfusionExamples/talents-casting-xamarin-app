using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TalentsCastingApp.Models;

namespace TalentsCastingApp.ViewModels
{
    public class TalentViewModel
    {
        public ObservableCollection<Talents> talents { get; set; }

        public TalentViewModel()
        {
            talents = new ObservableCollection<Talents>
            {
                new Talents
                {
                    Picture = "MathildaLane",
                    Name = "Mathilda Lane",
                    Age = "29 years",
                    Rating = "5",
                    Location = "Riga, Latvia",
                    skills = new List<Skills>
                    {
                        new Skills { Descripcion = "Bike riding"   },
                        new Skills { Descripcion = "Swimming"      },
                        new Skills { Descripcion = "Skiing"        },
                        new Skills { Descripcion = "Hourse riding" }
                    }
                },
                new Talents
                {
                    Picture  = "IdaAlexander",
                    Name     = "Ida Alexander",
                    Age      = "23 years",
                    Rating   = "4",
                    Location = "Paris, France",
                    skills   = new List<Skills>
                    {
                        new Skills { Descripcion = "Swimming"   },
                        new Skills { Descripcion = "Bike riding" },
                        new Skills { Descripcion = "Hourse riding"},
                        new Skills { Descripcion = "Skiing" }
                    }
                },
                new Talents
                {
                    Picture  = "MathildaLane",
                    Name     = "Hanna King",
                    Age      = "22 years",
                    Rating   = "2",
                    Location = "Miami, Florida",
                    skills   = new List<Skills>
                    {
                        new Skills { Descripcion = "Bike riding"   },
                        new Skills { Descripcion = "Swimming"      },
                        new Skills { Descripcion = "Skiing"        },
                        new Skills { Descripcion = "Hourse riding" } 
                    }
                }
            };
        }

    }
}
