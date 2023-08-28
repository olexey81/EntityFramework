using System;
using System.Collections.Generic;

namespace Library_DAL;

public partial class PublCodeType
{
    public int PublCodeTypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
