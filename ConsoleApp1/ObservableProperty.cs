
public class ObservableProperty<T>
{
    private Action<T> _onValueChanged;
    private T _value;

    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            _onValueChanged?.Invoke(value);
        }
    }
    
    public void Subscribe(Action<T> onValueChanged)
    {
        _onValueChanged += onValueChanged;
    }

    public void Unsubscribe(Action<T> onValueChanged)
    {
        _onValueChanged -= onValueChanged;
    }

    public void UnsubscribeAll()
    {
        _onValueChanged = null;
    }
}