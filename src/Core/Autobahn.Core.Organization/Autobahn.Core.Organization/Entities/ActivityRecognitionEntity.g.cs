//***************************************************************************
//* DomainName: Organization Models
//* FileName:   ActivityRecognitionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IActivityRecognition file
/// </summary>
[Table("ActivityRecognition", Schema = "Organization")]
public partial class ActivityRecognitionEntity : EntityBase, IActivityRecognition
{
    #region "IActivityRecognition Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Recognition for Participation or Performance in an Activity
    /// <para>
    /// The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19229">Recognition for Participation or Performance in an Activity</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefActivityRecognitionType")]
    [Comment("The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity.")]
    public Guid RefActivityRecognitionTypeId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19229">Recognition for Participation or Performance in an Activity</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Organization domain
    /// </remarks>
    /// </summary>
    public virtual RefActivityRecognitionTypeEntity RefActivityRecognitionTypeEntity { get; set; }

    #endregion
}
