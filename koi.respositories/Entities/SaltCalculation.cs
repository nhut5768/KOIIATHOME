using System;
using System.Collections.Generic;

namespace koi.respositories.Entities;

public partial class SaltCalculation
{
    public int Id { get; set; }

    public int? PondId { get; set; }

    public DateTime CalculationDate { get; set; }

    public decimal? Amount { get; set; }

    public virtual Pond? Pond { get; set; }
}
