using System;
using System.Collections.Generic;

namespace Library_DAL;

public partial class DocumentsType
{
    public int DocTypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<Reader> Readers { get; set; } = new List<Reader>();
}
