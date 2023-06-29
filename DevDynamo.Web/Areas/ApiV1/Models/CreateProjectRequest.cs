using System.ComponentModel.DataAnnotations;

namespace DevDynamo.Web.Areas.ApiV1.Models
{
  public class CreateProjectRequest
  {
    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    public string Template { get; set; } = null!;
  }
    public class NextStatusResponse
    {
        [StringLength(100)]
        public string Status { get; set; } = null!;

        [StringLength(100)]
        public string Description { get; set; } = null!;
    }

}
