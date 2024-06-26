﻿namespace rm_sciage.domain.DTOs.Site;

public class SiteDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int ZipCode { get; set; }
    public string Status { get; set; } = string.Empty;
}