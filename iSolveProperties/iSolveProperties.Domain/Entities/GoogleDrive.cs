using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class GoogleDrive
{
    public byte SerialNo { get; set; }

    public byte CompId { get; set; }

    public string JsonPath { get; set; } = null!;

    public string DriveFolderId { get; set; } = null!;

    public string ApplicationName { get; set; } = null!;
}
