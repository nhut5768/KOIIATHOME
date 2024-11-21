using System;
using System.Collections.Generic;

namespace koi.respositories.Entities;

public partial class WaterParameter
{
    public int Id { get; set; }

    public int? PondId { get; set; }

    public DateTime MeasurementDate { get; set; }

    public decimal? Temperature { get; set; }

    public decimal? Salt { get; set; }

    public decimal? Ph { get; set; }

    public decimal? O2 { get; set; }

    public decimal? No2 { get; set; }

    public decimal? No3 { get; set; }

    public decimal? Po4 { get; set; }

    public virtual Pond? Pond { get; set; }
}
