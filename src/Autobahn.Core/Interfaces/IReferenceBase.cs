//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   IReferenceBase.cs
//**********************************************************

/// <summary>
/// The use of a source of information in order to ascertain
/// something.  In this case a valid list of items to choose
/// from.
/// </summary>
public partial interface IReferenceBase
{
    /// <summary>
    /// The primary key of the model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Defines the Description non nullable property
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// Defines the Code non nullable property
    /// </summary>
    string Code { get; set; }

    /// <summary>
    /// Defines the Definition non nullable property
    /// </summary>
    string Definition { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="Organization"/> model
    /// </summary>
    Guid? RefJurisdictionId { get; set; }

    /// <summary>
    /// Defines the SortOrder nullable property
    /// </summary>
    decimal? SortOrder { get; set; }
}