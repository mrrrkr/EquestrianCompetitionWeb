using System;
using System.Collections.Generic;

namespace EquestrianCompetitionsWebApp.Models;

public partial class Team
{
    public int IdTeam { get; set; }

    public string Name { get; set; } = null!;

    public string Region { get; set; } = null!;

    public virtual ICollection<Sportsman> Sportsmen { get; set; } = new List<Sportsman>();
}
