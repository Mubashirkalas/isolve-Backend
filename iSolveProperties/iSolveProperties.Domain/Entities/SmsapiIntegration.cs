using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SmsapiIntegration
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Masking { get; set; }

    public short? SubSegmentId { get; set; }

    public string? EmailUserName { get; set; }

    public string? EmailPassword { get; set; }

    public string? EmailPort { get; set; }

    public string? Apikey { get; set; }

    public string? SmtpClients { get; set; }

    public bool? EnableSsls { get; set; }
}
