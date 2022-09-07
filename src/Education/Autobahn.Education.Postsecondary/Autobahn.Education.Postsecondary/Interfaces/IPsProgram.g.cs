//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   IPsProgram.g.cs
//***************************************************************************

/// <summary>
/// The IPsProgram file
/// </summary>
public partial interface IPsProgram
{
    #region "IPsProgram Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Normal Length of Time for Completion
    /// <para>
    /// The amount of time necessary for a person to complete all requirements for a degree or certificate according to the institution's catalog. This is typically 4 years (8 semesters or trimesters, or 12 quarters, excluding summer terms) for a bachelor's degree in a standard term-based institution; 2 years (4 semesters or trimesters, or 6 quarters, excluding summer terms) for an associate's degree in a standard term-based institution; and the various scheduled times for certificate programs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19197">Normal Length of Time for Completion</a>
    /// </para>
    /// </summary>
    System.String NormalLengthTimeForCompletion { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Program Length Hours
    /// <para>
    /// The normal length in credit/contact hours of a person's program as published in the institution's catalogue, website, or other official documents.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19223">Program Length Hours</a>
    /// </para>
    /// </summary>
    Decimal? ProgramLengthHours { get; set; }

    /// <summary>
    /// Classification of Instructional Program Code
    /// <para>
    /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
    /// </para>
    /// </summary>
    Guid? RefCipCodeId { get; set; }

    /// <summary>
    /// Classification of Instructional Program Version
    /// <para>
    /// The version of CIP being reported.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19045">Classification of Instructional Program Version</a>
    /// </para>
    /// </summary>
    Guid? RefCipVersionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDqpcategoriesOfLearning"/> model
    /// </summary>
    Guid? RefDqpcategoriesOfLearningId { get; set; }

    /// <summary>
    /// Program Length Hours Type
    /// <para>
    /// The type of hours (credit or contact) by which the normal length of a program of study is measured.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19224">Program Length Hours Type</a>
    /// </para>
    /// </summary>
    Guid? RefProgramLengthHoursTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPsprogramLevel"/> model
    /// </summary>
    Guid? RefPsprogramLevelId { get; set; }

    /// <summary>
    /// Normal Length of Time for Completion Units
    /// <para>
    /// The unit of measurement for length of time for completion.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19198">Normal Length of Time for Completion Units</a>
    /// </para>
    /// </summary>
    Guid? RefTimeForCompletionUnitsId { get; set; }

    #endregion
}
