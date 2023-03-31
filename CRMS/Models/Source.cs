using Microsoft.Build.Framework;
using System.ComponentModel;

namespace CRMS.Models
{
    public class Source
    {
        public Guid Source_Id { get; set; } = Guid.Empty;

        [Required]
        [DisplayName("Source: ")]
        public string SourceName { get; set; } = string.Empty;

        public Source() { }

        public Source(Guid id, string sourceName)
        {
            Source_Id = id;
            SourceName = sourceName;
        }
    }
}
