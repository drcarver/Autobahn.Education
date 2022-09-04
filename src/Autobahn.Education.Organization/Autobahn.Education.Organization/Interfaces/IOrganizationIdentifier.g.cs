//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationIdentifier.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationIdentifier file
/// </summary>
public partial interface IOrganizationIdentifier
{
    #region "IOrganizationIdentifier Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Course Identifier
    /// <para>
    /// The actual code that identifies the organization of subject matter and related learning experiences provided for the instruction of students.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19055">Course Identifier</a>
    /// </para>
    /// </summary>
    System.String Identifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Course Code System
    /// <para>
    /// A system that is used to identify the organization of subject matter and related learning experiences provided for the instruction of students.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19056">Course Code System</a>
    /// </para>
    /// </summary>
    Guid? RefOrganizationIdentificationSystemId { get; set; }

    /// <summary>
    /// Activity Identifier
    /// <para>
    /// A unique number or alphanumeric code used in the local system to identify an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19006">Activity Identifier</a>
    /// </para>
    /// </summary>
    Guid? RefOrganizationIdentifierTypeId { get; set; }

    #endregion
}
