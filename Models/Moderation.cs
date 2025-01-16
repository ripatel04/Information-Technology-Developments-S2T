using System;


namespace Moderation.Models
{
    public partial class ModerationEntry
    {

        public required string Moderator_id { get; set; }
        public string Moderator_Name { get; set; }
        //public required string User_id { get; set; }
        public DateTime Date_Updated { get; set; }
        public required string  Document_id { get; set; }
        public required DateTime Date { get; set; }
        public required string Comments { get; set; }
        public int? Ratings { get; set; }
       
    }

     public class UpdateModerationRequest
    {
        public required string Status { get; set; }
        public required string Comment { get; set; }

        public int Rating { get; set; }
    }
}