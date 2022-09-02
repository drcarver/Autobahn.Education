//***************************************************************************
//* DomainName: Common Models
//* FileName:   ProfessionalDevelopmentActivityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IProfessionalDevelopmentActivity file
/// </summary>
public partial class ProfessionalDevelopmentActivityModel : AutobahnBaseModel, IProfessionalDevelopmentActivity
{
    #region "IProfessionalDevelopmentActivity Properties"
    /// <summary>
    /// Professional Development Activity Code
    /// <para>
    /// A code assigned to an professional development activity by the organization offering the activity that is unique to the non-variable activity details.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20404">Professional Development Activity Code</a>
    /// </para>
    /// </summary>
    public System.String ActivityCode { get; set; }

    /// <summary>
    /// Professional Development Activity Identifier
    /// <para>
    /// A unique number or alphanumeric code assigned to the Professional Development Activity as assigned by the organization offering the training.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19808">Professional Development Activity Identifier</a>
    /// </para>
    /// </summary>
    public System.String ActivityIdentifier { get; set; }

    /// <summary>
    /// Professional Development Activity Approval Code
    /// <para>
    /// A code given to an activity by an approval organization to designate it as an approved activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20402">Professional Development Activity Approval Code</a>
    /// </para>
    /// </summary>
    public System.String ApprovalCode { get; set; }

    /// <summary>
    /// Professional Development Activity Cost
    /// <para>
    /// The cost for an attendee to participate in a professional development activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20405">Professional Development Activity Cost</a>
    /// </para>
    /// </summary>
    public Decimal? Cost { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    public Guid? CourseId { get; set; }

    /// <summary>
    /// Professional Development Activity Credits
    /// <para>
    /// The number of credits a professional development activity provides.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20407">Professional Development Activity Credits</a>
    /// </para>
    /// </summary>
    public Decimal? Credits { get; set; }

    /// <summary>
    /// Professional Development Activity Objective
    /// <para>
    /// The expected outcomes of a participant in an activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20410">Professional Development Activity Objective</a>
    /// </para>
    /// </summary>
    public System.String Objective { get; set; }

    /// <summary>
    /// Professional Development Activity State Approved Status
    /// <para>
    /// An indication of whether a training activity has been approved through a state process.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20598">Professional Development Activity State Approved Status</a>
    /// </para>
    /// </summary>
    public Boolean? ProfessionalDevelopmentActivityStateApprovedStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentRequirement"/> model
    /// </summary>
    public Guid ProfessionalDevelopmentRequirementId { get; set; }

    /// <summary>
    /// Professional Development Publish Activity Indicator
    /// <para>
    /// An indicator of whether the professional development activity should be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20415">Professional Development Publish Activity Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? PublishIndicator { get; set; }

    /// <summary>
    /// Course Credit Units
    /// <para>
    /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19057">Course Credit Units</a>
    /// </para>
    /// </summary>
    public Guid? RefCourseCreditUnitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityApprovedPurpose"/> model
    /// </summary>
    public Guid? RefPdactivityApprovedPurposeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityCreditType"/> model
    /// </summary>
    public Guid? RefPdactivityCreditTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityLevel"/> model
    /// </summary>
    public Guid? RefPdactivityLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityType"/> model
    /// </summary>
    public Guid? RefPdactivityTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdaudienceType"/> model
    /// </summary>
    public Guid? RefPdaudienceTypeId { get; set; }

    /// <summary>
    /// Professional Development Financial Support Type
    /// <para>
    /// The type of financial assistance received in support of non-credit professional development activities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19811">Professional Development Financial Support Type</a>
    /// </para>
    /// </summary>
    public Guid? RefProfessionalDevelopmentFinancialSupportId { get; set; }

    /// <summary>
    /// Professional Development Scholarship Status
    /// <para>
    /// An indication of whether a scholarship was received for the person to participate in the professional development.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19810">Professional Development Scholarship Status</a>
    /// </para>
    /// </summary>
    public Boolean? ScholarshipStatus { get; set; }

    /// <summary>
    /// Professional Development Activity Title
    /// <para>
    /// The title of an activity designed for the purpose of developing someone professionally.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19809">Professional Development Activity Title</a>
    /// </para>
    /// </summary>
    public System.String Title { get; set; }

    #endregion
}
