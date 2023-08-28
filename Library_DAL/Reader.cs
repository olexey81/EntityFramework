using System;
using System.Collections.Generic;

namespace Library_DAL;

public partial class Reader
{
    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string DocumentNumber { get; set; } = null!;

    public int? DocumentType { get; set; }

    public virtual DocumentsType? DocumentTypeNavigation { get; set; }
}
