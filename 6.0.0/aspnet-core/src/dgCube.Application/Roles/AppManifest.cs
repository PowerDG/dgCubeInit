using System.Collections.Generic;

namespace dgCube.Roles
{
 
        public class AppManifest
        {
            /// <summary>
            /// 
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Version { get; set; }
            /// <summary>
            /// 
            /// Redis是一个开源的使用ANSI C语言编写、遵守BSD协议、支持网络、可基于内存亦可持久化的日志型、Key-Value数据库，并提供多种语言的API
            /// </summary>
            public string Description { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Icon { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<string> Banner { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<string> Tags { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public EnterprisesCard EnterprisesCard { get; set; }
            /// <summary>
            /// redis的5种数据结构
            /// </summary>
            public string Title { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string ContentType { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string ContentRef { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<string> Videos { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<string> Images { get; set; }
        }
  
}