using System;
using System.Collections.Generic;

namespace EquestrianCompetitionsWebApp.Models;

public partial class SportsCoupleTest
{
    public int IdSportsCoupleTest { get; set; }

    public int IdSportsCouple { get; set; }

    public int IdCompetition { get; set; }

    public int IdTest { get; set; }

    public DateTime? TimeToStart { get; set; }

    public int? FinalPlace { get; set; }

    public virtual SportsCoupleCompetition Id { get; set; } = null!;

    public virtual Test IdTestNavigation { get; set; } = null!;
}
