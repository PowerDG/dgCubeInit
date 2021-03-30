

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using dgCube;

namespace dgCube.Dtos
{
    public class CreateOrUpdateApplicationInfoInput
    {
        [Required]
        public ApplicationInfoEditDto ApplicationInfo { get; set; }
							
							//// custom codes
									
							

							//// custom codes end
    }
}