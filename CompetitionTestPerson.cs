using System;
using System.Collections.Generic;

namespace EquestrianCompetitionsWebApp.Models;

public partial class CompetitionTestPerson
{
    public int IdCompetitionTestPerson { get; set; }

    public int IdCompetitionTest { get; set; }

    public int IdPerson { get; set; }

    public virtual CompetitionTest IdCompetitionTestNavigation { get; set; } = null!;

    public virtual Person IdPersonNavigation { get; set; } = null!;

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();
}
