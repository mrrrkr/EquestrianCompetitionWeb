using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EquestrianCompetitionsWebApp.Models;

public partial class Test
{
    public int IdTest { get; set; }

    public string Name { get; set; } = null!;

    public TimeSpan Time { get; set; }

    public string RulesForJudging { get; set; } = null!;

    public enum kind_discipline
    {
        [Description("выездка")]
        выездка,
        [Description("конкур")]
        конкур
    }

    public virtual ICollection<CompetitionTest> CompetitionTests { get; set; } = new List<CompetitionTest>();

    public virtual ICollection<SportsCoupleTest> SportsCoupleTests { get; set; } = new List<SportsCoupleTest>();
}
