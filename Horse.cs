using System;
using System.Collections.Generic;

namespace EquestrianCompetitionsWebApp.Models;

public partial class Horse
{
    public int IdHorse { get; set; }

    public string Nickname { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public string Father { get; set; } = null!;

    public string PlaceOfBirth { get; set; } = null!;

    public bool VeterinaryInspection { get; set; }

    public int IdPerson { get; set; }

    public virtual Person IdPersonNavigation { get; set; } = null!;

    public virtual ICollection<SportsCouple> SportsCouples { get; set; } = new List<SportsCouple>();
}
