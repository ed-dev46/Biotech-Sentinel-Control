namespace BiotechSentinelControl;

public interface IRisk
{
    public RiskEnum RiskLevel { get; }
    public void AlertProtocol();
}