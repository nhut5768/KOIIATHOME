using System;
using System.Collections.Generic;

namespace koi.respositories.Entities;

public partial class Fish
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }

    public string? BodyShape { get; set; }

    public int? Age { get; set; }

    public decimal? Size { get; set; }

    public decimal? Weight { get; set; }

    public string? Gender { get; set; }

    public string? Breed { get; set; }

    public string? Origin { get; set; }

    public decimal? Price { get; set; }

    public int? PondId { get; set; }

    public virtual ICollection<FeedCalculation> FeedCalculations { get; set; } = new List<FeedCalculation>();

    public virtual Pond? Pond { get; set; }
}
