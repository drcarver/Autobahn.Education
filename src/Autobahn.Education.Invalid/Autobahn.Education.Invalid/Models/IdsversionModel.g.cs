//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IdsversionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIdsversion file
/// </summary>
public partial class IdsversionModel : AutobahnBaseModel, IIdsversion
{
    #region "IIdsversion Properties"
    public System.Boolean CurrentVersion { get; set; }

    public System.DateTime IdsversionDate { get; set; }

    public System.String IdsversionNumber { get; set; }

    #endregion
}
