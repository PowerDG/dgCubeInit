namespace dgCube.Roles
{
    /// <summary>
    /// 企业 销售名片
    /// 适宜同作config
    /// </summary>
    public class EnterprisesCard
    {
        /// <summary>
        /// 服务商
        /// 森亿科技有限公司
        /// </summary>
        /// <value></value>
        public string ServiceProvider { get; set; }

        /// <summary>
        /// 客服热线
        /// </summary>
        /// <value></value>
        public string CustomerServiceHotline { get; set; }

        /// <summary>
        /// 服务时间
        /// 周一至之周五8:00-18:00
        /// </summary>
        /// <value></value>
        public string ServiceTime { get; set; }

        /// <summary>
        /// 电子邮件
        /// </summary>
        /// <value></value>
        public string Email { get; set; }


        /// <summary>
        /// 二维码图地址
        /// </summary>
        /// <value></value>
        public string QRCodeUrl { get; set; }
    }
}