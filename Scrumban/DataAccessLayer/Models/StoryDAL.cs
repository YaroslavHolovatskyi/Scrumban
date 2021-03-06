﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Scrumban.DataAccessLayer.Models
{
    [Table("Story")]
    public class StoryDAL
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Story_id { get; set; }

        [ForeignKey("StoryState")]
        public int StoryState_id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }
        
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        //Navigation properties
        public StoryStateDAL StoryState { get; set; }
    }
}
