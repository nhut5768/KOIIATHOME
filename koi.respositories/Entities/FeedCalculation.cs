using System;
using System.Collections.Generic;

namespace koi.respositories.Entities;

public partial class FeedCalculation
{
    public int Id { get; set; }

    public int? FishId { get; set; }

    public DateTime FeedingDate { get; set; }

    public decimal? Amount { get; set; }

    public virtual Fish? Fish { get; set; }
}
