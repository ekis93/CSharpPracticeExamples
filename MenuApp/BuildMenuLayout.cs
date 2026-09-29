// ReSharper disable ConvertToPrimaryConstructor
namespace MenuApp;
public class BuildMenuLayout
{
    private readonly string _title;
    private readonly Dictionary<char, string> _menuItems = new();
    public BuildMenuLayout(string title)
    {
        _title = title;
    }
    public void AddMenuItem(char subMenuNumber, string subMenuName)
    {
        _menuItems.Add(subMenuNumber, subMenuName);
    }
    public override string ToString()
    {
        string menuLayout = _title;
        if (_menuItems.Count > 0)
        {
            foreach (KeyValuePair<char,string> item in _menuItems)
            {
                menuLayout += "\n"+item.Key+" "+item.Value;
            }
        }
        else
        {
            throw new InvalidOperationException("Please call the "+nameof(AddMenuItem)+" method at least once" +
                                                " before using the instance of "+GetType().Name);
        }
        menuLayout += "\n\nPlease pick an item from the list.";
        return menuLayout;
    }
}