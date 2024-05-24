using System;
using System.Collections.Generic;

namespace EquestrianCompetitionsWebApp.Models;

public partial class Sportsman
{
    public int IdSportsman { get; set; }

    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public int RegistrationNumber { get; set; }

    public bool MedicalCertificate { get; set; }

    public int IdTeam { get; set; }

    public virtual Team IdTeamNavigation { get; set; } = null!;

    public virtual ICollection<SportsCouple> SportsCouples { get; set; } = new List<SportsCouple>();
}
