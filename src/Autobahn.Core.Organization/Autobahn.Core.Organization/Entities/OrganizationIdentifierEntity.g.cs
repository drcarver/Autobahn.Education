//***************************************************************************
//* DomainName: Organization Models
//* FileName:   OrganizationIdentifierEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationIdentifier file
/// </summary>
[Table("OrganizationIdentifier", Schema = "Autobahn.Core.Organization")]
public partial class OrganizationIdentifierEntity : EntityBase, IOrganizationIdentifier
{
    #region "IOrganizationIdentifier Properties"
    /// <summary>
    /// Course Identifier
    /// <para>
    /// The actual code that identifies the organization of subject matter and related learning experiences provided for the instruction of students.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19055">Course Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The actual code that identifies the organization of subject matter and related learning experiences provided for the instruction of students.")]
    public System.String Identifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Course Code System
    /// <para>
    /// A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19056">Course Code System</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefOrganizationentificationSystem")]
    [Comment("A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students.")]
    public Guid? RefOrganizationIdentificationSystemId { get; set; }

    /// <summary>
    /// Activity Identifier
    /// <para>
    /// A unique number or alphanumeric code used in the local system to identify an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19006">Activity Identifier</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefOrganizationentifierType")]
    [Comment("A unique number or alphanumeric code used in the local system to identify an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.")]
    public Guid? RefOrganizationIdentifierTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
