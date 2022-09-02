//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonLearningDeviceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonLearningDevice file
/// </summary>
[Table("PersonLearningDevice", Schema = "Common")]
public partial class PersonLearningDeviceEntity : EntityBase, IPersonLearningDevice
{
    #region "IPersonLearningDevice Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Primary Learning Device Access
    /// <para>
    /// An indication of whether the primary learning device is shared or not shared with another individual
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20952">Primary Learning Device Access</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPrimaryLearningDeviceAccess")]
    [Comment("An indication of whether the primary learning device is shared or not shared with another individual")]
    public Guid? RefPrimaryLearningDeviceAccessId { get; set; }

    /// <summary>
    /// Primary Learning Device Away From School
    /// <para>
    /// The type of device the student uses most often to complete learning activities away from school.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20953">Primary Learning Device Away From School</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPrimaryLearningDeviceAwayFromSchool")]
    [Comment("The type of device the student uses most often to complete learning activities away from school.")]
    public Guid? RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }

    /// <summary>
    /// Primary Learning Device Provider
    /// <para>
    /// The provider of the primary learning device.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20954">Primary Learning Device Provider</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefPrimaryLearningDeviceProvider")]
    [Comment("The provider of the primary learning device.")]
    public Guid? RefPrimaryLearningDeviceProviderId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// An indication of whether the primary learning device is shared or not shared with another individual
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20952">Primary Learning Device Access</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefPrimaryLearningDeviceAccessEntity RefPrimaryLearningDeviceAccessEntity { get; set; }

    /// <summary>
    /// The type of device the student uses most often to complete learning activities away from school.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20953">Primary Learning Device Away From School</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefPrimaryLearningDeviceAwayFromSchoolEntity RefPrimaryLearningDeviceAwayFromSchoolEntity { get; set; }

    /// <summary>
    /// The provider of the primary learning device.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20954">Primary Learning Device Provider</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefPrimaryLearningDeviceProviderEntity RefPrimaryLearningDeviceProviderEntity { get; set; }

    #endregion
}
