﻿using System.ComponentModel.DataAnnotations;

namespace ClincManagement.API.Contracts.Review.Requests
{
    public record AddReviewRequest
    {
        [Required]
        public Guid PatientId { get; init; }


        [Range(1, 5)]
        public int Rating { get; init; }


        public string Comment { get; init; } = string.Empty;
    }

}
