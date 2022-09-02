//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   AutobahnBaseModel.cs
//**********************************************************

/// <summary>
/// The base model for autobahn.  All models inherit from 
/// this
/// </summary>
public class AutobahnBaseModel : IAutobahnBase
{
    /// <summary>
    /// The Id of the item
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Is it a deleted item?
    /// </summary>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// True if the item is new and unsaved
    /// </summary>
    public bool IsNew { get; set; }

    /// <summary>
    /// Set when a model is changed
    /// </summary>
    public bool IsChanged { get; private set; }

    /// <summary>
    /// Accept changes to the class and reset all changed
    /// flags
    /// </summary>
    public void AcceptChanges()
    {
        IsNew = false;
        IsChanged = false;
    }
}