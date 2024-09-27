using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TestDemo
{
    public string? StatusMachine { get; set; }

    public string? StatusOnOff { get; set; }

    public string? StatusComm { get; set; }

    public DateTime? StatusMachineTimeOnOff { get; set; }

    public DateTime? StatusOnOffTimeOnOff { get; set; }

    public DateTime? StatusCommTimeOnOff { get; set; }

    public DateOnly? Date { get; set; }

    public string? MachineName { get; set; }
}
