using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library_DAL;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public int Author { get; set; }

    public string PublCode { get; set; } = null!;

    public int? PublCodeType { get; set; }

    public int Year { get; set; }

    public string Country { get; set; } = null!;

    public string? City { get; set; }

    public virtual Author AuthorNavigation { get; set; } = null!;

    public virtual ICollection<BooksAuthor> BooksAuthors { get; set; } = new List<BooksAuthor>();

    public virtual PublCodeType? PublCodeTypeNavigation { get; set; }

    [MaxLength(400)]
    public string? Genre { get; set; }
}
