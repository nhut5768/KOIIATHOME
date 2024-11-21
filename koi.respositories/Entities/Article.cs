using System;
using System.Collections.Generic;

namespace koi.respositories.Entities;

public partial class Article
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Content { get; set; }

    public DateTime PublicationDate { get; set; }
}
