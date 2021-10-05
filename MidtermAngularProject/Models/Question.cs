using System;
using System.Collections.Generic;

#nullable disable

namespace MidtermAngularProject.Models
{
    public partial class Question
    {
        public Question()
        {
            Favorites = new HashSet<Favorite>();
        }

        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }
    }
}
