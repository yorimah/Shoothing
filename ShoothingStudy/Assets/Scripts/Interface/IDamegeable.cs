public interface IDamegeable
{
    public int hp { get; set; }

    int defenceLayer { get; set; }

    public void TakeDamege(int damege);

    public void Die();
}
