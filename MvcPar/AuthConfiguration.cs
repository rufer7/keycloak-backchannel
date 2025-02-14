﻿namespace MvcPar;

public class AuthConfiguration
{
    public string StsServerIdentityUrl { get; set; } = string.Empty;
    public string Audience { get; set; } = string.Empty;
    public string ClientSecret { get; set; } = string.Empty;
}
