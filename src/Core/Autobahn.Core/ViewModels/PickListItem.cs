//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   PickListItemViewModel.cs
//***************************************************************************

/// <summary>
/// An item in a pick list
/// </summary>
public class PickListItemViewModel : ObservableObject
{
    // private member variable for the Item's description
    private string? description;

    // private member variable for the item's id
    private Guid id;

    /// <summary>
    /// The Id of the item
    /// </summary>
    public Guid Id
    {
        get => id;
        set => SetProperty(ref id, value);
    }

    /// <summary>
    /// The description of the item in the list
    /// </summary>
    public string? Description
    {
        get => description;
        set => SetProperty(ref description, value);
    }

    /// <summary>
    /// The sort order of the item in the list
    /// </summary>
    public decimal SortOrder { get; set; }
}
