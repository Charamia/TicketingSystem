﻿namespace TicketingSystem.Web.ViewMoldes.Comments
{
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using TicketingSystem.Models;
    using TicketSystem.Web.Infrastructure.Mapping;

    public class PostCommentViewModel : IMapFrom<Comment>
    {

        public PostCommentViewModel()
        {

        }
        public PostCommentViewModel(int ticketId)
        {
            this.TicketId = ticketId;
        }

        public int TicketId { get; set; }


        [Required]
        [StringLength(1000, MinimumLength =100)]
        [UIHint("MultiLineText")]
        public string Content  {get; set;}

      
    }
}