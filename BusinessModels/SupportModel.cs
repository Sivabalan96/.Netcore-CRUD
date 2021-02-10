using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessModels
{
    public class SupportModel
    {
        public int Id { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }

        public String Status { get; set; }

        public String Assignee { get; set; }

        public String Priority { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
