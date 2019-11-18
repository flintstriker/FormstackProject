using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormstackProject.Models
{
    public class Form
    {
        [DisplayName("Form ID")]
        public int FormId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }

    public class FormDBContext : DbContext
    {
        public DbSet<Form> Forms { get; set; }
    }
}