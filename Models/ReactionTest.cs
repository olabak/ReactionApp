using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReactionTimeApp.Models
{
    public class ReactionTest
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public TimeSpan ReactionTime { get; set; }
        public int UserAge { get; set; }
        public string UserDevice { get; set; }


        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
