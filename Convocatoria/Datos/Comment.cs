using System;
using System.Collections.Generic;

namespace Datos
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public bool? Attended { get; set; }
    }
}
