//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefPersonLocationTypeEntity.g.cs
//* Name:       Address Type for Learner or Family
//* Definition: The type of address listed for a learner or a parent, guardian, family member or related person.
//***************************************************************************

/// <summary>
/// Address Type for Learner or Family <see cref="RefPersonLocationType"/>
/// <para>
/// The type of address listed for a learner or a parent, guardian, family member or related person.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19358">Address Type for Learner or Family</a>
/// </para>
/// </summary>
[Table("RefPersonLocationType", Schema = "Common")]
[Comment("The type of address listed for a learner or a parent, guardian, family member or related person.")]
public partial class RefPersonLocationTypeEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefPersonLocationType Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAddressType"/> model
    /// </summary>
    [ForeignKey("RefAddressType")]
    public Guid? RefAddressTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRole"/> model
    /// </summary>
    [ForeignKey("Role")]
    public Guid? RoleId { get; set; }

    #endregion
}
