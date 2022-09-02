//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   IAutobahnBase.cs
//**********************************************************

using System.ComponentModel;

/// <summary>
/// The base interface for autobahn.  All model classes implement 
/// this
/// </summary>
public partial interface IAutobahnBase : IChangeTracking
{
    /// <summary>
    /// The Id of the item
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Is it a deleted item?
    /// </summary>
    bool IsDeleted { get; set; }

    /// <summary>
    /// True if the item is new and unsaved
    /// </summary>
    bool IsNew { get; set; }
}