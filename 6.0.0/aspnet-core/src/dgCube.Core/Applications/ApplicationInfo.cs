using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dgCube
{
    [Table("application_Info")]
    /// <summary>
    /// 应用详情信息
    /// </summary>
    public class ApplicationInfo:Entity
    {

        /// <summary>
        /// Id
        /// </summary>
        /// <value></value>
        [Description("Id主键")]
        [Column("id")]
        public virtual int Id { get; set; }

        #region Base 基础信息
        /// <summary>
        /// 应用名name
        /// </summary>
        /// <value></value>
        [Column("application_name")]
        [Description("应用名name")]
        public virtual string ApplicationName { get; set; }


        /// <summary>
        /// 应用名 软文标题
        /// </summary>
        /// <value></value>
        [Column("application_title")]
        [Description("软文标题")]
        public virtual string ApplicationTitle { get; set; }


        /// <summary>
        /// 应用系统介绍description
        /// </summary>
        /// <value></value>
        [Column("introduction")]
        [Description("应用系统介绍description")]
        public virtual string Introduction { get; set; }


        /// <summary>
        /// 服务商
        /// </summary>
        /// <value></value>
        [Column("service_provider")]
        [Description("服务商")]
        public virtual string ServiceProvider { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        /// <value></value>
        [Column("vsrsion")]
        [Description("版本号")]
        public virtual string Version { get; set; }

        /// <summary>
        /// 上传地址
        /// </summary>
        /// <value></value>
        [Column("url")]
        [Description("上传地址")]
        public virtual string Url { get; set; }

        #endregion


        #region Info 扩展信息



        /// <summary>
        /// 部署状态
        /// </summary>
        /// <value></value>
        [Column("status")]
        [Description("部署状态")]
        public virtual DeploymentStatus Status { get; set; }


        /// <summary>
        /// 上传地址
        /// </summary>
        /// <value></value>
        [Column("IconUrl")]
        [Description("图标地址")]
        public virtual string IconUrl { get; set; }


        /// <summary>
        /// 轮播图banner
        /// </summary>
        /// <value></value>
        [Column("Images")]
        [Description("轮播图banner")]
        public virtual string Images { get; set; }

        /// <summary>
        /// 轮播视频banner
        /// </summary>
        /// <value></value>
        [Column("Videos")]
        [Description("轮播视频banner")]
        public virtual string Videos { get; set; }



        /// <summary>
        /// 版本号
        /// </summary>
        /// <value></value>
        [Column("tags")]
        [Description("tags")]
        public virtual string Tags { get; set; }

        /// <summary>
        /// 软文正文内容
        /// </summary>
        /// <value></value>
        [Column("content_ref")]
        [Description("软文正文内容")]
        public virtual string ContentRef { get; set; }

        /// <summary>
        /// 软文正文内容格式
        /// </summary>
        /// <value></value>
        [Column("content_type")]
        [Description("软文正文内容格式")]
        public virtual string ContentType { get; set; }


        [Column("enterprises_card")]
        [Description("企业名片信息")]
        public virtual string EnterprisesCardJson { get; set; }

        #endregion


        #region auditing information  冗余审计信息

        /// <summary>
        /// 
        /// </summary>
        [Column("created_user")]
        public virtual string CreatedUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Column("created_time")]
        public virtual DateTime CreatedTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Column("modify_userid")]
        public virtual int? ModifyUser { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Column("last_modified_time")]
        public virtual DateTime? LastModifiedTime { get; set; }
        #endregion

    }
    /// <summary>
    /// 部署状态
    /// </summary>
    public enum DeploymentStatus
    {

        /// <summary>
        ///     未部署
        /// </summary>
        [Description("未部署")] None = 0,


        /// <summary>
        ///     已部署
        /// </summary>
        [Description("已部署")] Done = 1,

        /// <summary>
        ///     有开通建议
        /// </summary>
        [Description("有开通建议")] Suggested = 2,
    }
}
