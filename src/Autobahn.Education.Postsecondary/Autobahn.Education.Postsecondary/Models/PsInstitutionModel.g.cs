//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsInstitutionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsInstitution file
/// </summary>
public partial class PsInstitutionModel : AutobahnBaseModel, IPsInstitution
{
    #region "IPsInstitution Properties"
    /// <summary>
    /// Institutionally Controlled Housing Status
    /// <para>
    /// An indication of whether an institution has any residence hall or housing facility located on- or off-campus that is owned or controlled by an institution and used by the institution in direct support of or in a manner related to, the institution's educational purposes.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19727">Institutionally Controlled Housing Status</a>
    /// </para>
    /// </summary>
    public Boolean? InstitutionallyControlledHousingStatus { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Administrative Funding Control
    /// <para>
    /// The type of education institution as classified by its funding source.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19012">Administrative Funding Control</a>
    /// </para>
    /// </summary>
    public Guid? RefAdministrativeFundingControlId { get; set; }

    /// <summary>
    /// Admission Consideration Level
    /// <para>
    /// The level of consideration given a type of admission criteria used at an institution during the selection process.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20558">Admission Consideration Level</a>
    /// </para>
    /// </summary>
    public Guid? RefAdmissionConsiderationLevelId { get; set; }

    /// <summary>
    /// Admission Consideration Type
    /// <para>
    /// The type of admission consideration used at an institution during the selection process.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20559">Admission Consideration Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAdmissionConsiderationTypeId { get; set; }

    /// <summary>
    /// Carnegie Basic Classification
    /// <para>
    /// The Basic Classification is an update of the traditional classification framework developed by the Carnegie Commission on Higher Education in 1970 to support its research program, and later published in 1973 for use by other researchers.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19038">Carnegie Basic Classification</a>
    /// </para>
    /// </summary>
    public Guid? RefCarnegieBasicClassificationId { get; set; }

    /// <summary>
    /// Control of Institution
    /// <para>
    /// A classification of whether a postsecondary institution is operated by publicly elected or appointed officials (public control) or by privately elected or appointed officials and derives its major source of funds from private sources (private control). 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19048">Control of Institution</a>
    /// </para>
    /// </summary>
    public Guid? RefControlOfInstitutionId { get; set; }

    /// <summary>
    /// Increased Learning Time Type
    /// <para>
    /// The types of increased learning time provided.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19164">Increased Learning Time Type</a>
    /// </para>
    /// </summary>
    public Guid? RefIncreasedLearningTimeTypeId { get; set; }

    /// <summary>
    /// Level of Institution
    /// <para>
    /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19178">Level of Institution</a>
    /// </para>
    /// </summary>
    public Guid? RefLevelOfInstitutionId { get; set; }

    /// <summary>
    /// Predominant Calendar System
    /// <para>
    /// The method by which an institution structures most of its courses for the academic year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19705">Predominant Calendar System</a>
    /// </para>
    /// </summary>
    public Guid? RefPredominantCalendarSystemId { get; set; }

    /// <summary>
    /// Tenure System
    /// <para>
    /// An indicator of whether an institution has personnel positions that lead to consideration for tenure.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19715">Tenure System</a>
    /// </para>
    /// </summary>
    public Guid? RefTenureSystemId { get; set; }

    /// <summary>
    /// Virtual Indicator
    /// <para>
    /// Indicates a school, institution, program, or course section focuses primarily on instruction in which students and teachers are separated by time and/or location and interact through the use of computers and/or telecommunications technologies.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20167">Virtual Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? VirtualIndicator { get; set; }

    #endregion
}
