//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   ActivityRecognitionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IActivityRecognition file
/// </summary>
public partial class ActivityRecognitionModel : AutobahnBaseModel, IActivityRecognition
{
    #region "IActivityRecognition Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
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
    public Guid RefActivityRecognitionTypeId { get; set; }

    #endregion
}
