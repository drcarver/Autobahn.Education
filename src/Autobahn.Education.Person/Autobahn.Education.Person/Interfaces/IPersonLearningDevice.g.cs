//***************************************************************************
//* DomainName: Person Models
//* FileName:   IPersonLearningDevice.g.cs
//***************************************************************************

/// <summary>
/// The IPersonLearningDevice file
/// </summary>
public partial interface IPersonLearningDevice
{
    #region "IPersonLearningDevice Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Primary Learning Device Access
    /// <para>
    /// An indication of whether the primary learning device is shared or not shared with another individual
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20952">Primary Learning Device Access</a>
    /// </para>
    /// </summary>
    Guid? RefPrimaryLearningDeviceAccessId { get; set; }

    /// <summary>
    /// Primary Learning Device Away From School
    /// <para>
    /// The type of device the student uses most often to complete learning activities away from school.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20953">Primary Learning Device Away From School</a>
    /// </para>
    /// </summary>
    Guid? RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }

    /// <summary>
    /// Primary Learning Device Provider
    /// <para>
    /// The provider of the primary learning device.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20954">Primary Learning Device Provider</a>
    /// </para>
    /// </summary>
    Guid? RefPrimaryLearningDeviceProviderId { get; set; }

    #endregion
}
