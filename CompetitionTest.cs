using System;
using System.Collections.Generic;

namespace EquestrianCompetitionsWebApp.Models;

public partial class CompetitionTest
{
    public int IdCompetitionTest { get; set; }

    public int IdCompetition { get; set; }

    public int IdTest { get; set; }

    public DateTime TimeStartTest { get; set; }

    public int? QuantitySportCouple { get; set; }

    public virtual ICollection<CompetitionTestPerson> CompetitionTestPeople { get; set; } = new List<CompetitionTestPerson>();

    public virtual Competition IdCompetitionNavigation { get; set; } = null!;

    public virtual Test IdTestNavigation { get; set; } = null!;
}
