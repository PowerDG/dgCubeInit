

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using dgCube;

namespace dgCube.EntityMapper.ApplicationInfos
{
    public class ApplicationInfoCfg : IEntityTypeConfiguration<ApplicationInfo>
    {
        public void Configure(EntityTypeBuilder<ApplicationInfo> builder)
        {

			 
      //   builder.ToTable("ApplicationInfos", YoYoAbpefCoreConsts.SchemaNames.CMS);
        builder.ToTable("ApplicationInfos");

            //可以自定义配置参数内容
			
							//// custom codes
									
							

							//// custom codes end
        }
    }
}


