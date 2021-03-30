using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dgCube
{

    [Table("external_log")]
    public class ExternalSMLog
    {
        /// <summary>
        /// ID
        /// </summary
        [Column("id")]
        [Description("Id主键")]
        public int Id { get; set; }

        [Column("request_json")]

        public string RequestJson { get; set; }
        [Column("response_data")]

        public string LogName { get; set; }
        [Column("log_note")]

        public string LogNote { get; set; }

        [Column("log_level")]
        public string LogLevel { get; set; }

        [Column("created_user")]
        public string CreatedUser { get; set; }

        [Column("created_time")]
        public DateTime CreatedTime { get; set; }

    }
}
