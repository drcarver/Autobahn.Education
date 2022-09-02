//***************************************************************************
//* DomainName: Common Models
//* FileName:   IProfessionalDevelopmentSession.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentSession file
/// </summary>
public partial interface IProfessionalDevelopmentSession
{
    #region "IProfessionalDevelopmentSession Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Professional Development Session Capacity
    /// <para>
    /// The total number of participants that can be accommodated by a professional development session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20416">Professional Development Session Capacity</a>
    /// </para>
    /// </summary>
    Int32? Capacity { get; set; }

    /// <summary>
    /// Professional Development Session End Date
    /// <para>
    /// The year, month and day a professional development session ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20417">Professional Development Session End Date</a>
    /// </para>
    /// </summary>
    DateTime? EndDate { get; set; }

    /// <summary>
    /// Professional Development Session End Time
    /// <para>
    /// The time at which a professional development session ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20418">Professional Development Session End Time</a>
    /// </para>
    /// </summary>
    System.String EndTime { get; set; }

    /// <summary>
    /// Professional Development Session Evaluation Method
    /// <para>
    /// The method used to evaluate a professional development session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20419">Professional Development Session Evaluation Method</a>
    /// </para>
    /// </summary>
    System.String EvaluationMethod { get; set; }

    /// <summary>
    /// Professional Development Session Evaluation Score
    /// <para>
    /// The score or rating used to determine if a professional development session was successful.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20420">Professional Development Session Evaluation Score</a>
    /// </para>
    /// </summary>
    System.String EvaluationScore { get; set; }

    /// <summary>
    /// Professional Development Activity Expiration Date
    /// <para>
    /// The year, month, and day on which any certificate awarded as part of a professional development activity expires.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20421">Professional Development Activity Expiration Date</a>
    /// </para>
    /// </summary>
    DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Professional Development Funding Source
    /// <para>
    /// The primary source of funding for a professional development session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20413">Professional Development Funding Source</a>
    /// </para>
    /// </summary>
    System.String FundingSource { get; set; }

    /// <summary>
    /// Professional Development Session Location Name
    /// <para>
    /// The name of a location where a professional development session will be held.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20424">Professional Development Session Location Name</a>
    /// </para>
    /// </summary>
    System.String LocationName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
    /// </summary>
    Guid ProfessionalDevelopmentActivityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEltrainerCoreKnowledgeArea"/> model
    /// </summary>
    Guid? RefEltrainerCoreKnowledgeAreaId { get; set; }

    /// <summary>
    /// Professional Development Session Language
    /// <para>
    /// The language in which the professional development session is delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20357">Professional Development Session Language</a>
    /// </para>
    /// </summary>
    Guid? RefLanguageId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPddeliveryMethod"/> model
    /// </summary>
    Guid? RefPddeliveryMethodId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdinstructionalDeliveryMode"/> model
    /// </summary>
    Guid? RefPdinstructionalDeliveryModeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdsessionStatus"/> model
    /// </summary>
    Guid? RefPdsessionStatusId { get; set; }

    /// <summary>
    /// Professional Development Session Identifier
    /// <para>
    /// The unique, non-duplicated,  identification number assigned by the registry data system for a session of a particular professional development activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20422">Professional Development Session Identifier</a>
    /// </para>
    /// </summary>
    System.String SessionIdentifier { get; set; }

    /// <summary>
    /// Sponsoring Agency Name
    /// <para>
    /// The name of the sponsoring agency.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20461">Sponsoring Agency Name</a>
    /// </para>
    /// </summary>
    System.String SponsoringAgencyName { get; set; }

    /// <summary>
    /// Professional Development Session Start Date
    /// <para>
    /// The year, month, and day a professional development session begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20426">Professional Development Session Start Date</a>
    /// </para>
    /// </summary>
    DateTime? StartDate { get; set; }

    /// <summary>
    /// Professional Development Session Start Time
    /// <para>
    /// The time at which a professional development session begins.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20427">Professional Development Session Start Time</a>
    /// </para>
    /// </summary>
    System.String StartTime { get; set; }

    /// <summary>
    /// Training and Technical Assistance Level
    /// <para>
    /// The level of expertise an individual training and technical assistance specialist has based on a set of established criteria.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20609">Training and Technical Assistance Level</a>
    /// </para>
    /// </summary>
    System.String TrainingAndTechnicalAssistanceLevel { get; set; }

    #endregion
}
