using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormDemoProject.Models
{
    public class Field
    {
        public int Id { get; set; }
        public bool Required { get; set; }
        public int DataTypeId { get; set; }
        public virtual DataType DataType { get; set; }
        public int FormId { get; set; }
        public virtual Form Form { get; set; }
    }
}