namespace orb.api.DTOs;

public class OrbDTO {
    public string? StateName { get; set; }
    public string CountyName { get; set; }
    public string? LastUpdate { get; set; }

    public string? CountyHomepage { get; set; }

    public string? SubNeed { get; set; }

    public string? WeSubscribe { get; set; }

    public string? SubTerm { get; set; }

    public string? SubFee { get; set; }

    public string? Tap { get; set; }

    public string? Rv { get; set; }

    public string? DtreeDesk { get; set; }

    public string? Ins { get; set; }

    public string? Props { get; set; }

    public string? Copy { get; set; }

    public string? CopyPmtMethod { get; set; }

    public string? CopyFeeAmt { get; set; }

    public string? CopySource { get; set; }

    public string? ImgDate { get; set; }

    public string? IndexDate { get; set; }

    public string? IndexSource { get; set; }

    public string? IndexPmtMethod { get; set; }

    public List<OrbDetailsDTO> resources { get; set; }
}

public class OrbDetailsDTO
{
    public string Type { get; set; }
    public string Url { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
}