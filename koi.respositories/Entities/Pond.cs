using System;
using System.Collections.Generic;

namespace koi.respositories.Entities;

public partial class Pond
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public decimal? Size { get; set; }

    public decimal? Depth { get; set; }

    public decimal? Volume { get; set; }

    public int? DrainCount { get; set; }

    public decimal? PumpCapacity { get; set; }

    public virtual ICollection<Fish> Fish { get; set; } = new List<Fish>();

    public virtual ICollection<SaltCalculation> SaltCalculations { get; set; } = new List<SaltCalculation>();

    public virtual ICollection<WaterParameter> WaterParameters { get; set; } = new List<WaterParameter>();
}
