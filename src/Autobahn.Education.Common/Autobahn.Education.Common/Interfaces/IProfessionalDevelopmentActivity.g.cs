//***************************************************************************
//* DomainName: Common Models
//* FileName:   IProfessionalDevelopmentActivity.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentActivity file
/// </summary>
public partial interface IProfessionalDevelopmentActivity
{
    #region "IProfessionalDevelopmentActivity Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Professional Development Activity Code
    /// <para>
    /// A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20404">Professional Development Activity Code</a>
    /// </para>
    /// </summary>
    System.String ActivityCode { get; set; }

    /// <summary>
    /// Professional Development Activity Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to the Professional Development Activity as assigned by the organization offering the training.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19808">Professional Development Activity Identifier</a>
    /// </para>
    /// </summary>
    System.String ActivityIdentifier { get; set; }

    /// <summary>
    /// Professional Development Activity Approval Code
    /// <para>
    /// A code given to an activity by an approval organization to designate it as an approved activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20402">Professional Development Activity Approval Code</a>
    /// </para>
    /// </summary>
    System.String ApprovalCode { get; set; }

    /// <summary>
    /// Professional Development Activity Cost
    /// <para>
    /// The cost for an attendee to participate in a professional development activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20405">Professional Development Activity Cost</a>
    /// </para>
    /// </summary>
    Decimal? Cost { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    Guid? CourseId { get; set; }

    /// <summary>
    /// Professional Development Activity Credits
    /// <para>
    /// The number of credits a professional development activity provides.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20407">Professional Development Activity Credits</a>
    /// </para>
    /// </summary>
    Decimal? Credits { get; set; }

    /// <summary>
    /// Professional Development Activity Objective
    /// <para>
    /// The expected outcomes of a participant in an activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20410">Professional Development Activity Objective</a>
    /// </para>
    /// </summary>
    System.String Objective { get; set; }

    /// <summary>
    /// Professional Development Activity State Approved Status
    /// <para>
    /// An indication of whether a training activity has been approved through a state process.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20598">Professional Development Activity State Approved Status</a>
    /// </para>
    /// </summary>
    Boolean? ProfessionalDevelopmentActivityStateApprovedStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> model
    /// </summary>
    Guid ProfessionalDevelopmentRequirementId { get; set; }

    /// <summary>
    /// Professional Development Publish Activity Indicator
    /// <para>
    /// An indicator of whether the professional development activity should be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20415">Professional Development Publish Activity Indicator</a>
    /// </para>
    /// </summary>
    Boolean? PublishIndicator { get; set; }

    /// <summary>
    /// Course Credit Units
    /// <para>
    /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
    /// </para>
    /// </summary>
    Guid? RefCourseCreditUnitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityApprovedPurpose"/> model
    /// </summary>
    Guid? RefPdactivityApprovedPurposeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityCreditType"/> model
    /// </summary>
    Guid? RefPdactivityCreditTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityLevel"/> model
    /// </summary>
    Guid? RefPdactivityLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityType"/> model
    /// </summary>
    Guid? RefPdactivityTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdaudienceType"/> model
    /// </summary>
    Guid? RefPdaudienceTypeId { get; set; }

    /// <summary>
    /// Professional Development Financial Support Type
    /// <para>
    /// The type of financial assistance received in support of non-credit professional development activities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19811">Professional Development Financial Support Type</a>
    /// </para>
    /// </summary>
    Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

    /// <summary>
    /// Professional Development Scholarship Status
    /// <para>
    /// An indication of whether a scholarship was received for the person to participate in the professional development.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19810">Professional Development Scholarship Status</a>
    /// </para>
    /// </summary>
    Boolean? ScholarshipStatus { get; set; }

    /// <summary>
    /// Professional Development Activity Title
    /// <para>
    /// The title of an activity designed for the purpose of developing someone professionally.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19809">Professional Development Activity Title</a>
    /// </para>
    /// </summary>
    System.String Title { get; set; }

    #endregion
}
