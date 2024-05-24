using System;
using System.Collections.Generic;

namespace EquestrianCompetitionsWebApp.Models;

public partial class Person
{
    public int IdPerson { get; set; }

    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public string FirdName { get; set; } = null!;

    public virtual ICollection<CompetitionTestPerson> CompetitionTestPeople { get; set; } = new List<CompetitionTestPerson>();

    public virtual ICollection<Horse> Horses { get; set; } = new List<Horse>();

    public virtual ICollection<SportsCouple> SportsCouples { get; set; } = new List<SportsCouple>();
}
