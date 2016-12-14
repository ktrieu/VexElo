struct Alliance
{

    public Alliance(string teamCode1, string teamCode2)
    {
        TeamCode1 = teamCode1;
        TeamCode2 = teamCode2;
    }
    
    public string TeamCode1 { get; set; }
    public string TeamCode2 { get; set; }
}