using System;
using System.Collections.Generic;

namespace EquestrianCompetitionsWebApp.Models;

public partial class Competition
{
    public int IdCompetition { get; set; }

    public string Title { get; set; } = null!;

    public DateOnly Date { get; set; }

    public string PlaceOfRealization { get; set; } = null!;

    public virtual ICollection<CompetitionTest> CompetitionTests { get; set; } = new List<CompetitionTest>();

    public virtual ICollection<SportsCoupleCompetition> SportsCoupleCompetitions { get; set; } = new List<SportsCoupleCompetition>();
}
