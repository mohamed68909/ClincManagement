﻿namespace ClincManagement.API.Contracts.Clinic.Respones
{
    public record DoctorListResponse
    {
        public Guid Id { get; init; }
        public string FullName { get; init; } = string.Empty;
        public string Specialization { get; init; } = string.Empty;
        public string ClinicName { get; init; } = string.Empty;
        public decimal Price { get; init; }
        public double Rating { get; init; }
        public int ReviewsCount { get; init; }
        public string ImageUrl { get; init; } = string.Empty;
        public DateTime NextAvailable { get; init; }

}

}
