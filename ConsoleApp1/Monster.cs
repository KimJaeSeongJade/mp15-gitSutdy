

public class Monster
{
    public ObservableProperty<int> Health { get; } = new ObservableProperty<int>();

    public Monster(int health)
    {
        Health.Value = health;
    }
}