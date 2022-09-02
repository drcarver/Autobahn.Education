//***************************************************************************
//* DomainName: Common Models
//* FileName:   IServiceProvided.g.cs
//***************************************************************************

/// <summary>
/// The IServiceProvided file
/// </summary>
public partial interface IServiceProvided
{
    #region "IServiceProvided Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Early Childhood Services Received
    /// <para>
    /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19321">Early Childhood Services Received</a>
    /// </para>
    /// </summary>
    Guid? RefServicesId { get; set; }

    /// <summary>
    /// Student Support Service Type
    /// <para>
    /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19273">Student Support Service Type</a>
    /// </para>
    /// </summary>
    Guid? RefStudentSupportServiceTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicesReceived"/> model
    /// </summary>
    Guid ServicesReceivedId { get; set; }

    #endregion
}
