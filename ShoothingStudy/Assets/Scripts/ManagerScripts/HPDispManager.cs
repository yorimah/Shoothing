public class HPDispManager
{
    IPlayerData playerData;

    public int GetPlayerHP()
    {
        playerData = Locator.Resolve<IPlayerData>();
        return playerData.PlayerHP;
    }
}
