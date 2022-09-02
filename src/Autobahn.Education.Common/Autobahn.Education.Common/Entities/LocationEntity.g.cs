//***************************************************************************
//* DomainName: Common Models
//* FileName:   LocationEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILocation file
/// </summary>
[Table("Location", Schema = "Common")]
public partial class LocationEntity : EntityBase, ILocation
{

    #region "Virtual Properties for foreign keys"
    #endregion
}
