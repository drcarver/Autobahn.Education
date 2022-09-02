//***************************************************************************
//* DomainName: Common Models
//* FileName:   ActivityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IActivity file
/// </summary>
[Table("Activity", Schema = "Common")]
public partial class ActivityEntity : EntityBase, IActivity
{
    #region "IActivity Properties"
    /// <summary>
    /// Activity Description
    /// <para>
    /// A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20505">Activity Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A description of the events and procedures that take place under the purview of an organized activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.")]
    public System.String ActivityDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
