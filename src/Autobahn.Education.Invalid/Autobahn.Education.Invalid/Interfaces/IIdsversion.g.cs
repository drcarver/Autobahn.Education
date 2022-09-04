//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IIdsversion.g.cs
//***************************************************************************

/// <summary>
/// The IIdsversion file
/// </summary>
public partial interface IIdsversion
{
    #region "IIdsversion Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.Boolean CurrentVersion { get; set; }

    System.DateTime IdsversionDate { get; set; }

    System.String IdsversionNumber { get; set; }

    #endregion
}
