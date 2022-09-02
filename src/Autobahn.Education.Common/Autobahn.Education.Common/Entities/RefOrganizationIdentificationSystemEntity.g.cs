//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefOrganizationIdentificationSystemEntity.g.cs
//* Name:       Activity Identifier
//* Definition: A unique number or alphanumeric code used in the local system to identify an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
//***************************************************************************

/// <summary>
/// Activity Identifier <see cref="RefOrganizationIdentificationSystem"/>
/// <para>
/// A unique number or alphanumeric code used in the local system to identify an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19006">Activity Identifier</a>
/// </para>
/// </summary>
[Table("RefOrganizationIdentificationSystem", Schema = "Common")]
[Comment("A unique number or alphanumeric code used in the local system to identify an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.")]
public partial class RefOrganizationIdentificationSystemEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefOrganizationIdentificationSystem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOrganizationentifierType"/> model
    /// </summary>
    [Obsolete("The RefOrganizationentifierType property is obsolete and will be removed in a later version")]
    [ForeignKey("RefOrganizationentifierType")]
    public Guid? RefOrganizationIdentifierTypeId { get; set; }

    #endregion
}
