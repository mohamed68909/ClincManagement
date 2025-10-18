﻿namespace ClincManagement.API.Contracts.Appointments.Responses
{
    public class AppointmentDetailsResponse
    {
        public string Status { get; set; } = string.Empty;
        public string AppointmentId { get; set; } = string.Empty;
        public string ReferenceCode { get; set; } = string.Empty;
        public string InvoiceId { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
        public DoctorDetails DoctorDetails { get; set; } = new();
        public BookingTime BookingTime { get; set; } = new();
        public FinancialSummary FinancialSummary { get; set; } = new();
        public string Notes { get; set; } = string.Empty;
    }

    public class DoctorDetails
    {
        public string Name { get; set; } = string.Empty;
        public string ClinicName { get; set; } = string.Empty;
    }

    public class BookingTime
    {
        public string Date { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
    }

    public class FinancialSummary
    {
        public decimal ConsultationFees { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPaid { get; set; }
    }
}
