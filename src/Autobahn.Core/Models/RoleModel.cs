//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   RoleModel.cs
//***************************************************************************

/// <summary>
/// A description of the way in which a person relates to an 
/// organization.
/// </summary>
public partial class RoleModel : AutobahnBaseModel, IRole
{
    #region "IRole Properties"
    /// <summary>
    /// Role
    /// <para>
    /// A description of the way in which a person relates to an 
    /// organization.
    /// </para>
    /// </summary>
    public System.String? Name { get; set; }

    /// <summary>
    /// Role Reference
    /// <para>
    /// A description of the way in which a person relates to an 
    /// organization.
    /// </para>
    /// </summary>
    public Guid? RefRoleId { get; set; }
    #endregion
}
