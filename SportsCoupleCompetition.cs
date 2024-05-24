using System;
using System.Collections.Generic;

namespace EquestrianCompetitionsWebApp.Models;

public partial class SportsCoupleCompetition
{
    public DateOnly DateOfRegistration { get; set; }

    public int IdSportsCouple { get; set; }

    public int IdCompetition { get; set; }

    public virtual Competition IdCompetitionNavigation { get; set; } = null!;

    public virtual SportsCouple IdSportsCoupleNavigation { get; set; } = null!;

    public virtual ICollection<SportsCoupleTest> SportsCoupleTests { get; set; } = new List<SportsCoupleTest>();
}
