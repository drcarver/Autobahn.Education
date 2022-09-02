//***************************************************************************
//* DomainName: Common Models
//* FileName:   StaffCredentialEntity.g.cs
//***************************************************************************

/// <summary>
/// The IStaffCredential file
/// </summary>
public partial class StaffCredentialModel : AutobahnBaseModel, IStaffCredential
{
    #region "IStaffCredential Properties"
    /// <summary>
    /// Cardiopulmonary Resuscitation Certification Expiration Date
    /// <para>
    /// The date an individual's cardiopulmonary resuscitation (CPR) training certification expires.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20065">Cardiopulmonary Resuscitation Certification Expiration Date</a>
    /// </para>
    /// </summary>
    public DateTime? CardiopulmonaryResuscitationCertification { get; set; }

    public Boolean? CteinstructorIndustryCertification { get; set; }

    /// <summary>
    /// Diploma or Credential Award Date
    /// <para>
    /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
    /// </para>
    /// </summary>
    public System.String DiplomaOrCredentialAwardDate { get; set; }

    /// <summary>
    /// First Aid Certification Expiration Date
    /// <para>
    /// The date an individual's first aid training certification expires.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20066">First Aid Certification Expiration Date</a>
    /// </para>
    /// </summary>
    public DateTime? FirstAidCertification { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonCredential"/> model
    /// </summary>
    public Guid PersonCredentialId { get; set; }

    /// <summary>
    /// Adult Education Certification Type
    /// <para>
    /// An indication of the category of the adult education certification a person holds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19775">Adult Education Certification Type</a>
    /// </para>
    /// </summary>
    public Guid? RefAeCertificationTypeId { get; set; }

    /// <summary>
    /// Child Development Associate Type
    /// <para>
    /// Type of Child Development Associate credential as defined by options.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19805">Child Development Associate Type</a>
    /// </para>
    /// </summary>
    public Guid? RefChildDevAssociateTypeId { get; set; }

    /// <summary>
    /// Paraprofessional Qualification Status
    /// <para>
    /// An indication of whether paraprofessionals are classified as qualified for their assignment according to state definition.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19207">Paraprofessional Qualification Status</a>
    /// </para>
    /// </summary>
    public Guid? RefParaprofessionalQualificationId { get; set; }

    /// <summary>
    /// Program Sponsor Type
    /// <para>
    /// A type of organization providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19692">Program Sponsor Type</a>
    /// </para>
    /// </summary>
    public Guid? RefProgramSponsorTypeId { get; set; }

    /// <summary>
    /// Teaching Credential Basis
    /// <para>
    /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19277">Teaching Credential Basis</a>
    /// </para>
    /// </summary>
    public Guid? RefTeachingCredentialBasisId { get; set; }

    /// <summary>
    /// Teaching Credential Type
    /// <para>
    /// An indication of the category of a legal document giving authorization to perform teaching assignment services.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19278">Teaching Credential Type</a>
    /// </para>
    /// </summary>
    public Guid? RefTeachingCredentialTypeId { get; set; }

    /// <summary>
    /// Technology Skills Standards Met
    /// <para>
    /// An indication that the person has achieved acceptable performance on a standards-based profile of technology user skills as defined by the state.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19537">Technology Skills Standards Met</a>
    /// </para>
    /// </summary>
    public Boolean? TechnologySkillsStandardsMet { get; set; }

    #endregion
}
