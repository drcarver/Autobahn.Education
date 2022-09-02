//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   PickListViewModel.cs
//***************************************************************************

using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

/// <summary>
/// A pick list
/// </summary>
public class PickListViewModel : ObservableObject
{
    // protected member variable for Selected Item
    private PickListItemViewModel? selectedPickListItem;

    // protected member variable for the Title of the list
    private string? title;

    /// <summary>
    /// The selected item from the list
    /// </summary>
    public PickListItemViewModel? SelectedItem { get => selectedPickListItem; set => SetProperty(ref selectedPickListItem, value); }

    /// <summary>
    /// The title of the list
    /// </summary>
    public string? Title { get => title; set => SetProperty(ref title, value); }

    /// <summary>
    /// The List of PickListItems
    /// </summary>
    public ObservableCollection<PickListItemViewModel>? PickListItemList { get; set; }
}
