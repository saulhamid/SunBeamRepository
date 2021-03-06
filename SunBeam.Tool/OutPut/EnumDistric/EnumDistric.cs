using System;
namespace SunBeam.Domain.Models
{
    public class EnumDistric
    {
      public int Id { get; set; }
      public string Name { get; set; }
      public int CountryId { get; set; }
      public int DivisionId { get; set; }
      public string Remarks { get; set; }
      public bool IsActive { get; set; }
      public bool IsArchive { get; set; }
      public string CreatedBy { get; set; }
      public string CreatedAt { get; set; }
      public string CreatedFrom { get; set; }
      public string LastUpdateBy { get; set; }
      public string LastUpdateAt { get; set; }
      public string LastUpdateFrom { get; set; }
    }
}
