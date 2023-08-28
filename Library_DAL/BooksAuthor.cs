﻿using System;
using System.Collections.Generic;

namespace Library_DAL;

public partial class BooksAuthor
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public int AuthorId { get; set; }

    public virtual Author Author { get; set; } = null!;

    public virtual Book Book { get; set; } = null!;
}
