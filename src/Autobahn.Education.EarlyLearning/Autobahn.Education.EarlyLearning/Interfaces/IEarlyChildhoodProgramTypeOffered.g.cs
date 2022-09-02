//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IEarlyChildhoodProgramTypeOffered.g.cs
//***************************************************************************

/// <summary>
/// The IEarlyChildhoodProgramTypeOffered file
/// </summary>
public partial interface IEarlyChildhoodProgramTypeOffered
{
    #region "IEarlyChildhoodProgramTypeOffered Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Inclusive Setting Indicator
    /// <para>
    /// Indicates that services are provided to the child in a place where children of all abilities learn together.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20615">Inclusive Setting Indicator</a>
    /// </para>
    /// </summary>
    Boolean? InclusiveSettingIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Community-based Type
    /// <para>
    /// Non domestic residence in which the early learning setting is located.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20614">Community-based Type</a>
    /// </para>
    /// </summary>
    Guid? RefCommunityBasedTypeId { get; set; }

    /// <summary>
    /// Early Childhood Program Enrollment Type
    /// <para>
    /// The system outlining activities and procedures based on a set of required services and standards in which the child is enrolled.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19829">Early Childhood Program Enrollment Type</a>
    /// </para>
    /// </summary>
    Guid RefEarlyChildhoodProgramEnrollmentTypeId { get; set; }

    #endregion
}
