//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonMasterEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonMaster file
/// </summary>
[Table("PersonMaster", Schema = "Person")]
public partial class PersonMasterEntity : EntityBase, IPersonMaster
{

    #region "Virtual Properties for foreign keys"
    #endregion
}
