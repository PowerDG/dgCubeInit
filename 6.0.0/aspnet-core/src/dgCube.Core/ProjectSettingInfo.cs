using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dgCube
{
    public class ProjectSettingInfo
    {
        /// <summary>
        /// Id
        /// </summary>
        /// <value></value>
        [Description("Id主键")]
        [Column("id")]
        public virtual int Id { get; set; }


        /// <summary>
        /// 上传地址
        /// </summary>
        /// <value></value>
        [Column("IconUrl")]
        [Description("图标地址")]
        public virtual string IconUrl { get; set; }

        /// <summary>
        /// 上传地址
        /// </summary>
        /// <value></value>
        [Column("IconUrl")]
        [Description("复制调阅地址备份")]
        public virtual string SubscribeAddress { get; set; }
        /// <summary>
        /// 上传地址
        /// </summary>
        /// <value></value>
        [Column("IconUrl")]
        [Description("门户名称")]
        public virtual string PortalName { get; set; }


        /// <summary>
        /// 上传地址
        /// </summary>
        /// <value></value>
        [Column("IconUrl")]
        [Description("门户最大打开tab上限")]
        public virtual int MaximumOfTab { get; set; }


        /// <summary>
        /// 上传地址 
        /// </summary>
        /// <value></value>
        [Column("IconUrl")]
        [Description("CS应用启用等待时间")]
        public virtual int StartupWaitSeconds { get; set; }



        /// <summary>
        /// 上传地址 
        /// </summary>
        /// <value></value>
        [Column("IconUrl")]
        [Description("CS应用启用等待时间")]
        public virtual int OwnerWorkNumber { get; set; }
    }
}                                       