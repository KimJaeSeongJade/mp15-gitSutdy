namespace ConsoleApp1;

public class UI
{
    private Monster _target;
    
    public UI(Monster monster)
    {
        _target = monster;
        monster.Health.Subscribe(RefreshUI);
    }

    private void RefreshUI(int value)
    {
        Console.WriteLine($"UI 갱신 : {value}");
    }
}