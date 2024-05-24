using System;
using System.Collections.Generic;

namespace EquestrianCompetitionsWebApp.Models;

public partial class SportsCouple
{
    public int IdSportsCouple { get; set; }

    public int IdPerson { get; set; }

    public int IdHorse { get; set; }

    public int IdSportsman { get; set; }

    public string Standings { get; set; } = null!;

    public virtual Horse IdHorseNavigation { get; set; } = null!;

    public virtual Person IdPersonNavigation { get; set; } = null!;

    public virtual Sportsman IdSportsmanNavigation { get; set; } = null!;

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();

    public virtual ICollection<SportsCoupleCompetition> SportsCoupleCompetitions { get; set; } = new List<SportsCoupleCompetition>();
}
