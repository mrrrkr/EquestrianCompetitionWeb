using System;
using System.Collections.Generic;

namespace EquestrianCompetitionsWebApp.Models;

public partial class Result
{
    public int IdResult { get; set; }

    public int IdSportsCouple { get; set; }

    public int IdCompetitionTestPerson { get; set; }

    public string Letter { get; set; } = null!;

    public int? Mistakes { get; set; }

    public int? TechnicalMistakes { get; set; }

    public float Points { get; set; }

    public float? Percentage { get; set; }

    public int? Place { get; set; }

    public string? Comment { get; set; }

    public virtual CompetitionTestPerson IdCompetitionTestPersonNavigation { get; set; } = null!;

    public virtual SportsCouple IdSportsCoupleNavigation { get; set; } = null!;
}
