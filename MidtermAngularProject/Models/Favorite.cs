using System;
using System.Collections.Generic;

#nullable disable

namespace MidtermAngularProject.Models
{
    public partial class Favorite
    {
        public int FavoriteId { get; set; }
        public int? QuestionId { get; set; }
        public int? UserId { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }

        public virtual Question Question { get; set; }
        public virtual User User { get; set; }
    }
}
