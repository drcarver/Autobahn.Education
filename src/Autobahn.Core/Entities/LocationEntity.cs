//***************************************************************************
//* DomainName: Autobahn.Core
//* FileName:   LocationEntity.cs
//***************************************************************************

/// <summary>
/// The ILocation file
/// </summary>
[Table("Location", Schema = "Core")]
public partial class LocationEntity : EntityBase, ILocation
{

    #region "Virtual Properties for foreign keys"
    #endregion
}
