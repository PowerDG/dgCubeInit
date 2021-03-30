
using Abp.Runtime.Validation;
using dgCube.Dtos;
using dgCube;

namespace dgCube.Dtos
{
	/// <summary>
	/// 获取的传入参数Dto
	/// </summary>
    public class GetApplicationInfosInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
		
							//// custom codes
									
							

							//// custom codes end
    }
}
